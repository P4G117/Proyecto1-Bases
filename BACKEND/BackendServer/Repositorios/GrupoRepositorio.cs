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
        //Obtener todos los Grupos
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

        //Obtener un Grupo según el ID
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
        //Crear un Nuevo Grupo
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
        //Actualizar un Grupo
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
        //Eliminar un Deportista de un Grupo
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
        //Consulta los Grupos de los que Todavia no es Miembro el Deportista
        public static List<GrupoBusqueda> GetGruposDisponibles(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                
                string query = "SELECT A.id_grupo, A.nombre" +
                    " FROM" +
                    " ((proyecto1.deportista_grupo AS J JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)" +
                    " JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)" +
                    " WHERE D.usuario_dep != '@Deportista'" +
                    " EXCEPT" +
                    " SELECT A.id_grupo, A.nombre" +
                    " FROM" +
                    " ((proyecto1.deportista_grupo AS J JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)" +
                    " JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)" +
                    " WHERE D.usuario_dep = '@Deportista'; ";

                query = query.Replace("@Deportista", deportista);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<GrupoBusqueda> listGrupoBusqueda = new List<GrupoBusqueda>();

                    while (reader.Read())
                    {
                        GrupoBusqueda grupoBusqueda = null;
                        grupoBusqueda = new GrupoBusqueda();
                        grupoBusqueda.idgrupo = Convert.ToInt32(reader.GetValue(0));
                        grupoBusqueda.nombre = reader.GetValue(1).ToString();
                        
                        listGrupoBusqueda.Add(grupoBusqueda);
                    }

                    return listGrupoBusqueda;
                }
            }

        }
        //Consulta los Grupos de los que Todavia no es Miembro el Deportista
        public static List<GrupoBusqueda> BusquedaGruposDisponibles(string deportista, string buscar)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                
                string query = "SELECT A.id_grupo, A.nombre" +
                    " FROM" +
                    " ((proyecto1.deportista_grupo AS J JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)" +
                    " JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)" +
                    " WHERE D.usuario_dep != '@Deportista' AND A.nombre LIKE '@Buscar%'" +
                    " EXCEPT" +
                    " SELECT A.id_grupo, A.nombre" +
                    " FROM" +
                    " ((proyecto1.deportista_grupo AS J JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)" +
                    " JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)" +
                    " WHERE D.usuario_dep = '@Deportista'; ";

                query = query.Replace("@Deportista", deportista);
                query = query.Replace("@Buscar", buscar);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<GrupoBusqueda> listGrupoBusqueda = new List<GrupoBusqueda>();

                    while (reader.Read())
                    {
                        GrupoBusqueda grupoBusqueda = null;
                        grupoBusqueda = new GrupoBusqueda();
                        grupoBusqueda.idgrupo = Convert.ToInt32(reader.GetValue(0));
                        grupoBusqueda.nombre = reader.GetValue(1).ToString();

                        listGrupoBusqueda.Add(grupoBusqueda);
                    }

                    return listGrupoBusqueda;
                }
            }

        }
        

    }
}
