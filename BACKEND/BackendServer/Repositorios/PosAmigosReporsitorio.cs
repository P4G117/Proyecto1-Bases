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
        //Consulta para ver los Posibles Amigos - Lista de los que todavia no son Amigos
        public static List<PosiblesAmigos> GetPosiblesAmigos(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2" +
                    " FROM proyecto1.deportista AS D" +
                    " EXCEPT" +
                    " SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2" +
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
                        posiblesAmigos.usuariodep = reader.GetValue(0).ToString();
                        posiblesAmigos.primer_nombre = reader.GetValue(1).ToString();
                        posiblesAmigos.apellido1 = reader.GetValue(2).ToString();
                        posiblesAmigos.apellido2 = reader.GetValue(3).ToString();

                        listPosiblesAmigos.Add(posiblesAmigos);
                    }

                    return listPosiblesAmigos;
                }
            }

        }
        //Consulta para ver los Following - Seguidos 
        public static List<Follow> GetFollowing(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                
                string query = "SELECT count(amigo) AS Seguidos" +
                    " FROM proyecto1.amigo AS A" +
                    " WHERE A.deportista = '@Deportista'; ";

                query = query.Replace("@Deportista", deportista);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Follow> listFollowing = new List<Follow>();

                    while (reader.Read())
                    {
                        Follow following = null;
                        following = new Follow();
                        following.follow = Convert.ToInt32(reader.GetValue(0));
                        
                        listFollowing.Add(following);
                    }

                    return listFollowing;
                }
            }

        }
        //Consulta para ver los Followers - Seguidores
        public static List<Follow> GetFollowers(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT count(deportista) AS Seguidores" +
                    " FROM proyecto1.amigo AS A" +
                    " WHERE A.amigo = '@Deportista'; ";

                query = query.Replace("@Deportista", deportista);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Follow> listFollowing = new List<Follow>();

                    while (reader.Read())
                    {
                        Follow following = null;
                        following = new Follow();
                        following.follow = Convert.ToInt32(reader.GetValue(0));

                        listFollowing.Add(following);
                    }

                    return listFollowing;
                }
            }

        }
        //Ver el total de Actividades de un Deportista
        public static List<Follow> GetTotalActividades(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT count(nombreactividad) AS Actividades" +
                    " FROM proyecto1.actividad AS A" +
                    " WHERE A.id_deportista = '@Deportista'; ";

                query = query.Replace("@Deportista", deportista);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Follow> listFollowing = new List<Follow>();

                    while (reader.Read())
                    {
                        Follow following = null;
                        following = new Follow();
                        following.follow = Convert.ToInt32(reader.GetValue(0));

                        listFollowing.Add(following);
                    }

                    return listFollowing;
                }
            }

        }
        //Obtener la Edad de un Deportista
        
        public static List<Follow> GetEdadDeportista(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT date_part('year',age(D.fecnac)) AS Edad" +
                    " FROM proyecto1.deportista AS D" +
                    " WHERE D.usuario_dep = '@Deportista'; ";

                query = query.Replace("@Deportista", deportista);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Follow> listFollowing = new List<Follow>();

                    while (reader.Read())
                    {
                        Follow following = null;
                        following = new Follow();
                        following.follow = Convert.ToInt32(reader.GetValue(0));

                        listFollowing.Add(following);
                    }

                    return listFollowing;
                }
            }

        }

    }
}
