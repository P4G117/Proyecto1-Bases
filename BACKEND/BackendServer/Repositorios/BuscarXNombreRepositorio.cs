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
    public class BuscarXNombreRepositorio
    {
        public static List<BusquedaPersonas> GetBusquedaNombre(string deportista, string buscar)
        {
            string connString = "Host=localhost;Port=5432;Database=StraviaTec;Username=postgres;Password=azofeifa1171290;";

            using (var conn = new NpgsqlConnection(connString))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                
                string query = "SELECT D.primer_nombre, D.apellido1, D.apellido2" +
                    " FROM proyecto1.deportista AS D" +
                    " WHERE D.primer_nombre LIKE '@Buscar%'" +
                    " EXCEPT" +
                    " SELECT D.primer_nombre, D.apellido1, D.apellido2" +
                    " FROM" +
                    " (proyecto1.amigo AS J RIGHT JOIN proyecto1.deportista AS D ON J.amigo = D.usuario_dep)" +
                    " WHERE J.deportista = '@Deportista'";

                query = query.Replace("@Deportista", deportista);
                query = query.Replace("@Buscar", buscar);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<BusquedaPersonas> listBusquedaPersonas = new List<BusquedaPersonas>();

                    while (reader.Read())
                    {
                        BusquedaPersonas busquedaPersonas = null;
                        busquedaPersonas = new BusquedaPersonas();
                        busquedaPersonas.primer_nombre = reader.GetValue(0).ToString();
                        busquedaPersonas.apellido1 = reader.GetValue(1).ToString();
                        busquedaPersonas.apellido2 = reader.GetValue(2).ToString();

                        listBusquedaPersonas.Add(busquedaPersonas);
                    }

                    return listBusquedaPersonas;
                }
            }

        }

    }
}
