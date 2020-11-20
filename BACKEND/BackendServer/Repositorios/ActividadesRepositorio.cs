using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using BackendServer.Models;
using BackendServer.Repositorios;

namespace BackendServer.Repositorios
{
    public class ActividadesRepositorio
    {
        public static List<Actividad> GetAllActividadesDep(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT A.id_actividad, A.nombreactividad, A.fecha, A.hora,A.mapa, A.kilometros, A.duracion, A.completitud, A.tipo_actividad" +
                    " FROM proyecto1.actividad AS A" +
                    " WHERE A.id_deportista = '@Deportista';" ;

                query = query.Replace("@Deportista", deportista);

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Actividad> listaActividades = new List<Actividad>();

                    while (reader.Read())
                    {
                        Actividad actividades = null;
                        actividades = new Actividad();
                        actividades.IdActividad = Convert.ToInt32(reader.GetValue(0).ToString());
                        actividades.Nombreactividad = reader.GetValue(1).ToString();
                        actividades.Fecha = reader.GetValue(2).ToString();
                        actividades.Hora = reader.GetValue(3).ToString();
                        actividades.Mapa = reader.GetValue(4).ToString();
                        actividades.Kilometros = Convert.ToInt32(reader.GetValue(5).ToString());
                        actividades.Duracion = reader.GetValue(6).ToString();
                        actividades.Completitud = reader.GetValue(7).ToString();
                        actividades.TipoActividad = reader.GetValue(7).ToString();

                        listaActividades.Add(actividades);
                    }

                    return listaActividades;
                }
            }
        }
        
        //Crear una nueva Actividad
        public static bool PostActividad(Actividad actividad)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.actividad(NombreActividad, Fecha, Hora, Mapa, Kilometros, Duracion, Completitud, Tipo_Actividad, ID_Deportista)" +
                    " VALUES('@Nombreactividad', '@Fecha', '@Hora', '@Mapa', @Kilometros, '@Duracion', '@Completitud', '@TipoActividad', '@IdDeportista'); ";

                query = query.Replace("@Nombreactividad", actividad.Nombreactividad)
                             .Replace("@Fecha", actividad.Fecha)
                             .Replace("@Hora", actividad.Hora)
                             .Replace("@Mapa", actividad.Mapa)
                             .Replace("@Kilometros", actividad.Kilometros.ToString())
                             .Replace("@Duracion", actividad.Duracion)
                             .Replace("@Completitud", actividad.Completitud)
                             .Replace("@TipoActividad", actividad.TipoActividad)
                             .Replace("@IdDeportista", actividad.IdDeportista);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
        //Actualizar la Información de un Deportista
        public static bool UpdateActividad(int idactividad, Actividad actividad)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "UPDATE proyecto1.actividad SET nombreactividad = '@Nombreactividad', fecha = '@Fecha', hora = '@Hora', mapa ='@Mapa', kilometros = '@Kilometros'," +
                    " duracion = '@Duracion', completitud = '@Completitud', tipo_actividad = '@TipoActividad', id_deportista = '@IdDeportista' WHERE id_actividad = '@Actividad'; ";

                query = query.Replace("@Nombreactividad", actividad.Nombreactividad)
                            .Replace("@Fecha", actividad.Fecha)
                            .Replace("@Hora", actividad.Hora)
                            .Replace("@Mapa", actividad.Mapa)
                            .Replace("@Kilometros", actividad.Kilometros.ToString())
                            .Replace("@Duracion", actividad.Duracion)
                            .Replace("@Completitud", actividad.Completitud)
                            .Replace("@TipoActividad", actividad.TipoActividad)
                            .Replace("@IdDeportista", actividad.IdDeportista)
                            .Replace("@Actividad", idactividad.ToString());
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
        //Eliminar una Actividad
        public static bool DeleteActividad(int idactividad)
        {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "DELETE FROM proyecto1.actividad WHERE id_actividad ='@Actividad'";

                query = query.Replace("@Actividad", idactividad.ToString());
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
               
            }

        }
    }
}
