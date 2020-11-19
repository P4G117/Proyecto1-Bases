using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using BackendServer.Models;
using BackendServer.Repositorios;

namespace BackendServer.Repositorios
{
    public class RetoRepositorio
    {
        public static List<Reto> GetAllRetos()
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT R.Id_Reto, R.Nombre, R.Periodo, R.Privacidad, R.Tipo_Reto, " +
                    "R.Tipo_Actividad, R.Id_Organizador " +
                    "FROM proyecto1.reto AS R";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Reto> listaretos = new List<Reto>();

                    while (reader.Read())
                    {
                        Reto reto = null;
                        reto = new Reto();
                        reto.IdReto = Convert.ToInt32(reader.GetValue(0));
                        reto.Nombre = reader.GetValue(1).ToString();
                        reto.Periodo = reader.GetValue(2).ToString();
                        reto.Privacidad = Convert.ToBoolean(reader.GetValue(3));
                        reto.TipoReto = reader.GetValue(4).ToString();
                        reto.TipoActividad = reader.GetValue(5).ToString();
                        reto.IdOrganizador = reader.GetValue(6).ToString();

                        listaretos.Add(reto);
                    }
                    return listaretos;
                }
            }
        }
        public static List<Reto> GetReto(int reto)
        {
            Connexion connString = new Connexion();
            using (var conn = new NpgsqlConnection(connString.conexion)) {
                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT R.ID_Reto, R.Nombre, R.Periodo, R.Privacidad, R.Tipo_Reto, " +
                    "R.Tipo_Actividad, R.Id_Organizador " +
                    "FROM proyecto1.reto AS R " +
                    "WHERE R.ID_Reto = @Reto";

                query = query.Replace("@Reto", reto.ToString());

                using (var command = new NpgsqlCommand(query, conn))
                {
                    
                    var reader = command.ExecuteReader();
                    List<Reto> listaretos = new List<Reto>();

                    while (reader.Read())
                    {
                        Reto reto1 = null;
                        reto1 = new Reto();
                        reto1.IdReto = Convert.ToInt32(reader.GetValue(0));
                        reto1.Nombre = reader.GetValue(1).ToString();
                        reto1.Periodo = reader.GetValue(2).ToString();
                        reto1.Privacidad = Convert.ToBoolean(reader.GetValue(3));
                        reto1.TipoReto = reader.GetValue(4).ToString();
                        reto1.TipoActividad = reader.GetValue(5).ToString();
                        reto1.IdOrganizador = reader.GetValue(6).ToString();

                        listaretos.Add(reto1);
                    }
                    return listaretos;
                }
            }
        }

        public static bool PostReto(Reto reto)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.reto(Nombre, Periodo, Privacidad, Tipo_Reto, Tipo_Actividad, ID_Organizador) " +
                    "VALUES('@Nombre', '@Periodo', @Privacidad, '@Tipo_Reto', '@Tipo_Actividad', '@ID_Organizador');";

                query = query.Replace("@Nombre", reto.Nombre)
                             .Replace("@Periodo", reto.Periodo)
                             .Replace("@Privacidad", reto.Privacidad.ToString())
                             .Replace("@Tipo_Reto", reto.TipoReto)
                             .Replace("@Tipo_Actividad", reto.TipoActividad)
                             .Replace("@ID_Organizador", reto.IdOrganizador);
                             
                using (var command = new NpgsqlCommand(query, conn))
                {
                    command.ExecuteNonQuery();
                    command.Dispose();
                    return true;
                }
            }
        }

        public static bool UpdateReto(int idreto, Reto reto)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "UPDATE proyecto1.reto SET Nombre = '@Nombre', " +
                    "Periodo = '@Periodo', Privacidad = @Privacidad, Tipo_Reto = '@Tipo_Reto', " +
                    "Tipo_Actividad = '@Tipo_Actividad', ID_Organizador = '@ID_Organizador'" +
                    "WHERE ID_Reto = @Reto";

                query = query.Replace("@Reto", idreto.ToString())
                             .Replace("@Nombre", reto.Nombre)
                             .Replace("@Periodo", reto.Periodo)
                             .Replace("@Privacidad", reto.Privacidad.ToString())
                             .Replace("@Tipo_Reto", reto.TipoReto)
                             .Replace("@Tipo_Actividad", reto.TipoActividad)
                             .Replace("@ID_Organizador", reto.IdOrganizador);

                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
        public static bool DeleteReto(int idreto)
        {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "DELETE FROM proyecto1.reto WHERE ID_Reto = @Reto";
                query = query.Replace("@Reto", idreto.ToString());
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }

        }

    }
}
