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
    public class ActividadesAmigosRepositorio
    {
        public static List<ActividadesAmigos> GetActividadesAmigos(string deportista)
        {
            string connString = "Host=localhost;Port=5432;Database=StraviaTec;Username=postgres;Password=azofeifa1171290;";

            using (var conn = new NpgsqlConnection(connString))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT proyecto1.deportista.primer_nombre, proyecto1.deportista.apellido1,proyecto1.deportista.apellido2, proyecto1.deportista.foto," +
                    "proyecto1.actividad.nombreactividad, proyecto1.actividad.tipo_actividad, proyecto1.actividad.kilometros, proyecto1.actividad.duracion " +
                    "FROM ((proyecto1.amigo RIGHT JOIN proyecto1.deportista ON proyecto1.amigo.amigo = proyecto1.deportista.usuario_dep)" +
                    "RIGHT JOIN proyecto1.actividad ON proyecto1.amigo.amigo = proyecto1.actividad.id_deportista) WHERE proyecto1.amigo.deportista = '@Deportista'"; 

                query = query.Replace("@Deportista", deportista);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<ActividadesAmigos> listActividadesAmigos = new List<ActividadesAmigos>();

                    while (reader.Read())
                    {
                        ActividadesAmigos actividadesAmigos = null;
                        actividadesAmigos = new ActividadesAmigos();
                        actividadesAmigos.nombre = reader.GetValue(0).ToString();
                        actividadesAmigos.apellido1 = reader.GetValue(1).ToString();
                        actividadesAmigos.apellido2 = reader.GetValue(2).ToString();
                        actividadesAmigos.foto = reader.GetValue(3).ToString();
                        actividadesAmigos.nombreactividad = reader.GetValue(4).ToString();
                        actividadesAmigos.tipo_actividad = reader.GetValue(5).ToString();
                        actividadesAmigos.kilometros = Convert.ToInt32(reader.GetValue(6));
                        //TimeSpan var = TimeSpan.Parse(reader.GetValue(7));
                        actividadesAmigos.duracion = reader.GetValue(7).ToString();
                        
                        
                        listActividadesAmigos.Add(actividadesAmigos);
                    }

                    return listActividadesAmigos;
                }
            }

        }
    }
}
