using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using BackendServer.Models;
using BackendServer.Repositorios;

namespace BackendServer.Repositorios
{
    public class CarreraRepositorio
    {
        public static List<Carrera> GetAllCarreras()
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT C.Id_Carrera, C.Id_Organizador, C.Nombre, C.Fecha, C.Recorrido, C.Cuenta, " +
                    "C.Costo, C.Privacidad, C.Tipo_Actividad " +
                    "FROM proyecto1.carrera AS C";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Carrera> listacarrera = new List<Carrera>();

                    while (reader.Read())
                    {
                        Carrera carreras = null;
                        carreras = new Carrera();
                        carreras.idcarrera = Convert.ToInt32(reader.GetValue(0));
                        carreras.idorganizador = reader.GetValue(1).ToString();
                        carreras.nombre = reader.GetValue(2).ToString();
                        carreras.fecha = reader.GetValue(3).ToString();
                        carreras.recorrido = reader.GetValue(4).ToString();
                        carreras.cuenta = Convert.ToInt64(reader.GetValue(5));
                        carreras.costo = Convert.ToInt64(reader.GetValue(6));
                        carreras.privacidad = Convert.ToBoolean(reader.GetValue(7));
                        carreras.tipoActividad = reader.GetValue(8).ToString();
                       
                        listacarrera.Add(carreras);
                    }

                    return listacarrera;
                }
            }
        }

        public static List<Carrera> GetCarrera(int carrera)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT C.Id_Carrera, C.Id_Organizador, C.Nombre, C.Fecha, C.Recorrido, C.Cuenta, " +
                    "C.Costo, C.Privacidad, C.Tipo_Actividad " +
                    "FROM proyecto1.carrera AS C " +
                    "WHERE C.Id_Carrera = @Carrera";

                query = query.Replace("@Carrera", carrera.ToString());

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Carrera> listacarrera = new List<Carrera>();

                    while (reader.Read())
                    {
                        Carrera carreras = null;
                        carreras = new Carrera();
                        carreras.idcarrera = Convert.ToInt32(reader.GetValue(0));
                        carreras.idorganizador = reader.GetValue(1).ToString();
                        carreras.nombre = reader.GetValue(2).ToString();
                        carreras.fecha = reader.GetValue(3).ToString();
                        carreras.recorrido = reader.GetValue(4).ToString();
                        carreras.cuenta = Convert.ToInt64(reader.GetValue(5));
                        carreras.costo = Convert.ToInt64(reader.GetValue(6));
                        carreras.privacidad = Convert.ToBoolean(reader.GetValue(7));
                        carreras.tipoActividad = reader.GetValue(8).ToString();

                        listacarrera.Add(carreras);
                    }

                    return listacarrera;
                }
            }
        }

        public static bool PostCarrera(Carrera carrera)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.carrera(Id_Organizador, Nombre, Fecha, Recorrido, Cuenta, Costo," +
                    " Privacidad, Tipo_Actividad) VALUES('@ID_Organizador'," +
                    " '@Nombre', '@Fecha', '@Recorrido', @Cuenta, @Costo, @Privacidad, '@TipoActividad');";
                
                query = query.Replace("@ID_Organizador", carrera.idorganizador)
                             .Replace("@Nombre", carrera.nombre)
                             .Replace("@Fecha", carrera.fecha)
                             .Replace("@Recorrido", carrera.recorrido)
                             .Replace("@Cuenta", carrera.cuenta.ToString())
                             .Replace("@Costo", carrera.costo.ToString())
                             .Replace("@Privacidad", carrera.privacidad.ToString())
                             .Replace("@TipoActividad", carrera.tipoActividad);

                using (var command = new NpgsqlCommand(query, conn)) {
                    command.ExecuteNonQuery();
                    command.Dispose();
                    return true;
                }
            }
        }

        public static bool UpdateCarrera(int nombreCarrera,Carrera carrera)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "UPDATE proyecto1.carrera SET Nombre = '@NuevoNombre', " +
                    "Fecha = '@Fecha', Recorrido = '@Recorrido', Cuenta = '@Cuenta', " +
                    "Costo = '@Costo', Privacidad = @Privacidad, Tipo_Actividad = '@TipoActividad' " +
                    "WHERE Id_Carrera = '@Carrera'";

                query = query.Replace("@NuevoNombre", carrera.nombre)
                             .Replace("@Fecha", carrera.fecha)
                             .Replace("@Recorrido", carrera.recorrido)
                             .Replace("@Cuenta", carrera.cuenta.ToString())
                             .Replace("@Costo", carrera.costo.ToString())
                             .Replace("@Privacidad", carrera.privacidad.ToString())
                             .Replace("@TipoActividad", carrera.tipoActividad)
                             .Replace("@Carrera", nombreCarrera.ToString());

                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
        public static bool DeleteCarrera(int carrera)
        {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "DELETE FROM proyecto1.carrera WHERE Id_Carrera = @Carrera";
                query = query.Replace("@Carrera", carrera.ToString());
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }

        }

    }
}
