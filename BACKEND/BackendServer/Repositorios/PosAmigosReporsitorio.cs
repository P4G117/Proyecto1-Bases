using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BackendServer.Models;

namespace BackendServer.Repositorios
{
    public class PosAmigosReporsitorio
    {
        public static List<PosiblesAmigos> GetPosiblesAmigos(string deportista)
        {
            string connString = "Host=localhost;Port=5432;Database=StraviaTec;Username=postgres;Password=azofeifa1171290;";

            using (var conn = new NpgsqlConnection(connString))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT D.primer_nombre, D.apellido1, D.apellido2" +
                    " FROM proyecto1.deportista AS D" +
                    " EXCEPT" +
                    " SELECT D.primer_nombre, D.apellido1, D.apellido2" +
                    " FROM (proyecto1.amigo AS A RIGHT JOIN proyecto1.deportista AS D ON A.amigo = D.usuario_dep)" +
                    " WHERE A.deportista = '@Deportista'";

                query = query.Replace("@Deportista", deportista);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<PosiblesAmigos> listPosiblesAmigos = new List<PosiblesAmigos>();

                    while (reader.Read())
                    {
                        PosiblesAmigos posiblesAmigos = null;
                        posiblesAmigos = new PosiblesAmigos();
                        posiblesAmigos.primer_nombre = reader.GetValue(0).ToString();
                        posiblesAmigos.apellido1 = reader.GetValue(1).ToString();
                        posiblesAmigos.apellido2 = reader.GetValue(2).ToString();

                        listPosiblesAmigos.Add(posiblesAmigos);
                    }

                    return listPosiblesAmigos;
                }
            }

        }
    }
}
