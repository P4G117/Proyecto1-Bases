using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using BackendServer.Models;
using BackendServer.Repositorios;

namespace BackendServer.Repositorios
{
    public class GrupoRepositorio
    {
        public static List<Grupo> GetGrupos() {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT G.ID_Grupo, G.Nombre, G.Administrador " +
                    "FROM proyecto1.grupo AS G";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Grupo> listagrupos = new List<Grupo>();

                    while (reader.Read())
                    {
                        Grupo grupos = null;
                        grupos = new Grupo();
                        grupos.idgrupo = Convert.ToInt32(reader.GetValue(0));
                        grupos.nombre = reader.GetValue(1).ToString();
                        grupos.administrador = reader.GetValue(2).ToString();
                        

                        listagrupos.Add(grupos);
                    }

                    return listagrupos;
                }
            }
        }

        public static List<Grupo> GetGrupo(int idgrupo)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT G.ID_Grupo, G.Nombre, G.Administrador " +
                    "FROM proyecto1.grupo AS G " +
                    "WHERE ID_Grupo = @Grupo";

                query = query.Replace("@Grupo", idgrupo.ToString());

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Grupo> listagrupos = new List<Grupo>();

                    while (reader.Read())
                    {
                        Grupo grupos = null;
                        grupos = new Grupo();
                        grupos.idgrupo = Convert.ToInt32(reader.GetValue(0));
                        grupos.nombre = reader.GetValue(1).ToString();
                        grupos.administrador = reader.GetValue(2).ToString();


                        listagrupos.Add(grupos);
                    }

                    return listagrupos;
                }
            }
        }

        public static bool PostGrupo(Grupo grupo)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.grupo(Nombre, Administrador) " +
                    "VALUES('@Nombre', '@Administrador'); ";

                query = query.Replace("@Nombre", grupo.nombre)
                             .Replace("@Administrador", grupo.administrador);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }

        public static bool UpdateGrupo(int idgrupo, Grupo grupo)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "UPDATE proyecto1.grupo SET Nombre = '@Nombre', " +
                    "Administrador = '@Administrador' WHERE ID_Grupo = @ID_Grupo";

                query = query.Replace("@ID_Grupo", idgrupo.ToString())
                             .Replace("@Nombre", grupo.nombre)
                             .Replace("@Administrador", grupo.administrador);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
        public static bool DeleteDeportista(int grupo)
        {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "DELETE FROM proyecto1.grupo WHERE ID_Grupo ='@Grupo'";

                query = query.Replace("@Grupo", grupo.ToString());
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
                /*using (var command = new NpgsqlCommand(query, conn))
                {
                    
                    int nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows deleted={0}", nRows));
                }*/
            }

        }

    }
}
