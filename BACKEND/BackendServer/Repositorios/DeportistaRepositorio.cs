using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using BackendServer.Models;
using BackendServer.Repositorios;

namespace BackendServer.Repositorios
{
    public class DeportistaRepositorio
    {
        //Obtener todos los Deportistas
        public static List<Deportista> GetAllDeportistas()
        {
            Connexion connString = new Connexion();
         
            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT D.Usuario_dep, D.primer_nombre, D.Apellido1, D.Apellido2, " +
                    "D.FecNac, D.Nacionalidad, D.Foto, D.Clave " +
                    "FROM proyecto1.deportista AS D";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Deportista> listadeportistas = new List<Deportista>();

                    while (reader.Read())
                    {
                        Deportista deportistas = null;
                        deportistas = new Deportista();
                        deportistas.usuariodep = reader.GetValue(0).ToString();
                        deportistas.primernombre = reader.GetValue(1).ToString();
                        deportistas.apellido1 = reader.GetValue(2).ToString();
                        deportistas.apellido2 = reader.GetValue(3).ToString();
                        deportistas.fecnac = reader.GetValue(4).ToString();
                        deportistas.nacionalidad = reader.GetValue(5).ToString();
                        deportistas.foto = reader.GetValue(6).ToString();
                        deportistas.clave = reader.GetValue(7).ToString();

                        listadeportistas.Add(deportistas);
                    }

                    return listadeportistas;
                }
            }
        }
        //Obtener un solo Deportista
        public static List<Deportista> GetDeportistas(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT D.Usuario_dep, D.primer_nombre, D.Apellido1, D.Apellido2, " +
                    "D.FecNac, D.Nacionalidad, D.Foto, D.Clave " +
                    "FROM proyecto1.deportista AS D " +
                    "WHERE D.Usuario_dep = '@Deportista'";

                query = query.Replace("@Deportista", deportista);

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Deportista> listadeportistas = new List<Deportista>();

                    while (reader.Read())
                    {
                        Deportista deportistas = null;
                        deportistas = new Deportista();
                        deportistas.usuariodep = reader.GetValue(0).ToString();
                        deportistas.primernombre = reader.GetValue(1).ToString();
                        deportistas.apellido1 = reader.GetValue(2).ToString();
                        deportistas.apellido2 = reader.GetValue(3).ToString();
                        deportistas.fecnac = reader.GetValue(4).ToString();
                        deportistas.nacionalidad = reader.GetValue(5).ToString();
                        deportistas.foto = reader.GetValue(6).ToString();
                        deportistas.clave = reader.GetValue(7).ToString();

                        listadeportistas.Add(deportistas);
                    }

                    return listadeportistas;
                }
            }
        }
        //Crear un nuevo Deportista
        public static bool PostDeportista(Deportista deportista) {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion)) {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.deportista(Usuario_Dep, " +
                    "Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)" +
                    "VALUES('@Usuario', '@PrimerNombre', '@Apellido1', '@Apellido2', '@fecnac'," +
                    " '@Nacionalidad', '@Foto', '@Clave'); ";

                query = query.Replace("@Usuario", deportista.usuariodep)
                             .Replace("@PrimerNombre",deportista.primernombre)
                             .Replace("@Apellido1",deportista.apellido1)
                             .Replace("@Apellido2", deportista.apellido2)
                             .Replace("@fecnac", deportista.fecnac)
                             .Replace("@Nacionalidad", deportista.nacionalidad)
                             .Replace("@Foto", deportista.foto)
                             .Replace("@Clave", deportista.clave);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
        //Actualizar la Información de un Deportista
        public static bool UpdateDeportista(string usuario_dep,Deportista deportista) {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "UPDATE proyecto1.deportista SET Primer_Nombre = '@PrimerNombre', " +
                    "Apellido1 = '@Apellido1', Apellido2 = '@Apellido2', FecNac = '@fecnac', Nacionalidad = '@Nacionalidad', " +
                    "Foto = '@Foto', Clave = '@Clave' WHERE Usuario_Dep = '@Usuario'";

                query = query.Replace("@Usuario", usuario_dep)
                             .Replace("@PrimerNombre", deportista.primernombre)
                             .Replace("@Apellido1", deportista.apellido1)
                             .Replace("@Apellido2", deportista.apellido2)
                             .Replace("@fecnac", deportista.fecnac)
                             .Replace("@Nacionalidad", deportista.nacionalidad)
                             .Replace("@Foto", deportista.foto)
                             .Replace("@Clave", deportista.clave);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
        //Eliminar un Deportista
        public static bool DeleteDeportista(string deportista) {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "DELETE FROM proyecto1.deportista WHERE Usuario_Dep ='@Deportista'";

                query = query.Replace("@Deportista", deportista);
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
        //Ver la Carreras en que esta Inscrito el Deportista
        public static List<GrupoBusqueda> CarInscritasDep(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT C.id_carrera, C.nombre" +
                    " FROM" +
                    " (proyecto1.inscripcion AS I JOIN proyecto1.carrera AS C ON I.id_carrera = C.id_carrera)" +
                    " WHERE I.usuario_dep = '@Deportista'; ";

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
        //Ver los Retos en que esta Inscrito el Deportista
        public static List<GrupoBusqueda> RetInscritosDep(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT C.id_reto, C.nombre" +
                    " FROM" +
                    " (proyecto1.deportista_reto AS I JOIN proyecto1.reto AS C ON I.id_reto = C.id_reto)" +
                    " WHERE I.usuario_dep = '@Deportista'; ";

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
        //Ver los Grupos a los que Pertenece el Deportista
        public static List<Grupo> MisGruposDep(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT G.iD_grupo, G.nombre, O.primer_nombre ||' '|| O.apellido1 AS Administrador" +
                    " FROM((proyecto1.deportista_grupo AS D JOIN proyecto1.grupo AS G ON D.id_grupo = G.id_grupo)" +
                    " JOIN proyecto1.organizador AS O ON G.administrador = O.usuario_org)" +
                    " WHERE D.usuario_dep = '@Deportista'; ";

                query = query.Replace("@Deportista", deportista);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Grupo> listGrupo = new List<Grupo>();

                    while (reader.Read())
                    {
                        Grupo grupos = null;
                        grupos = new Grupo();
                        grupos.idgrupo = Convert.ToInt32(reader.GetValue(0));
                        grupos.nombre = reader.GetValue(1).ToString();
                        grupos.administrador = reader.GetValue(2).ToString();

                        listGrupo.Add(grupos);
                    }

                    return listGrupo;
                }
            }
        }
    }
}
