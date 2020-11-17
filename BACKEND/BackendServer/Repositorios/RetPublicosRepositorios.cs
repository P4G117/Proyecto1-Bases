using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BackendServer.Models;
using System.Globalization;

namespace BackendServer.Repositorios
{
    public class RetPublicosRepositorios
    {
        public static List<RetosPublicos> GetRetosPublicos()
        {
            string connString = "Host=localhost;Port=5432;Database=StraviaTec;Username=postgres;Password=azofeifa1171290;";

            using (var conn = new NpgsqlConnection(connString))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT nombre,periodo,tipo_reto,tipo_actividad FROM proyecto1.reto WHERE proyecto1.reto.privacidad = FALSE";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<RetosPublicos> listRetosPublicos = new List<RetosPublicos>();

                    while (reader.Read())
                    {
                        RetosPublicos retosPublicos = null;
                        retosPublicos = new RetosPublicos();
                        retosPublicos.nombre = reader.GetValue(0).ToString();
                        retosPublicos.periodo = reader.GetValue(1).ToString();
                        retosPublicos.tipo_reto = reader.GetValue(2).ToString();
                        retosPublicos.tipo_actividad = reader.GetValue(3).ToString();

                        listRetosPublicos.Add(retosPublicos);
                    }

                    return listRetosPublicos;
                }
            }

        }
    }
}
