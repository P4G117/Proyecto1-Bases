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
        Connexion connString = new Connexion();
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

        public static bool UpdateDeportista(Deportista deportista) {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "UPDATE proyecto1.deportista SET Primer_Nombre = '@PrimerNombre', " +
                    "Apellido1 = '@Apellido1', Apellido2 = '@Apellido2', FecNac = '@fecnac', Nacionalidad = '@Nacionalidad', " +
                    "Foto = '@Foto', Clave = '@Clave' WHERE Usuario_Dep = '@Usuario'";

                query = query.Replace("@Usuario", deportista.usuariodep)
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

    }
}
