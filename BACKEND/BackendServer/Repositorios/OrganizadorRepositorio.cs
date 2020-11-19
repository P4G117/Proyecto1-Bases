using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using BackendServer.Models;
using BackendServer.Repositorios;

namespace BackendServer.Repositorios
{
    public class OrganizadorRepositorio
    {
        public static List<Organizador> GetAllOrganizadores()
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT O.Usuario_org, O.Primer_Nombre, O.Apellido1, O.Apellido2, " +
                    "O.FecNac, O.Nacionalidad, O.Foto, O.Clave " +
                    "FROM proyecto1.organizador AS O";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Organizador> listaOrganizadores = new List<Organizador>();

                    while (reader.Read())
                    {
                        Organizador organizador = null;
                        organizador = new Organizador();
                        organizador.usuarioorg = reader.GetValue(0).ToString();
                        organizador.primernombre = reader.GetValue(1).ToString();
                        organizador.apellido1 = reader.GetValue(2).ToString();
                        organizador.apellido2 = reader.GetValue(3).ToString();
                        organizador.fecnac = reader.GetValue(4).ToString();
                        organizador.nacionalidad = reader.GetValue(5).ToString();
                        organizador.foto = reader.GetValue(6).ToString();
                        organizador.clave = reader.GetValue(7).ToString();

                        listaOrganizadores.Add(organizador);
                    }

                    return listaOrganizadores;
                }
            }

        }

        public static List<Organizador> GetOrganizador(string usuario_org)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT O.Usuario_org, O.Primer_Nombre, O.Apellido1, O.Apellido2, " +
                    "O.FecNac, O.Nacionalidad, O.Foto, O.Clave " +
                    "FROM proyecto1.organizador AS O " +
                    "WHERE Usuario_Org = '@Usuario'";

                query = query.Replace("@Usuario", usuario_org);
                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Organizador> listaOrganizadores = new List<Organizador>();

                    while (reader.Read())
                    {
                        Organizador organizador = null;
                        organizador = new Organizador();
                        organizador.usuarioorg = reader.GetValue(0).ToString();
                        organizador.primernombre = reader.GetValue(1).ToString();
                        organizador.apellido1 = reader.GetValue(2).ToString();
                        organizador.apellido2 = reader.GetValue(3).ToString();
                        organizador.fecnac = reader.GetValue(4).ToString();
                        organizador.nacionalidad = reader.GetValue(5).ToString();
                        organizador.foto = reader.GetValue(6).ToString();
                        organizador.clave = reader.GetValue(7).ToString();

                        listaOrganizadores.Add(organizador);
                    }

                    return listaOrganizadores;
                }
            }
        }

        public static bool PostOrganizador(Organizador organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.organizador(Usuario_Org, " +
                    "Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)" +
                    "VALUES('@Usuario', '@PrimerNombre', '@Apellido1', '@Apellido2', '@fecnac'," +
                    " '@Nacionalidad', '@Foto', '@Clave');";

                query = query.Replace("@Usuario", organizador.usuarioorg)
                             .Replace("@PrimerNombre", organizador.primernombre)
                             .Replace("@Apellido1", organizador.apellido1)
                             .Replace("@Apellido2", organizador.apellido2)
                             .Replace("@fecnac", organizador.fecnac)
                             .Replace("@Nacionalidad", organizador.nacionalidad)
                             .Replace("@Foto", organizador.foto)
                             .Replace("@Clave", organizador.clave);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }

        public static bool UpdateOrganizador(string usuario_org, Organizador organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "UPDATE proyecto1.organizador SET Primer_Nombre = '@PrimerNombre', " +
                    "Apellido1 = '@Apellido1', Apellido2 = '@Apellido2', FecNac = '@fecnac', Nacionalidad = '@Nacionalidad', " +
                    "Foto = '@Foto', Clave = '@Clave' WHERE Usuario_Org = '@Usuario'";

                query = query.Replace("@Usuario", usuario_org)
                             .Replace("@PrimerNombre", organizador.primernombre)
                             .Replace("@Apellido1", organizador.apellido1)
                             .Replace("@Apellido2", organizador.apellido2)
                             .Replace("@fecnac", organizador.fecnac)
                             .Replace("@Nacionalidad", organizador.nacionalidad)
                             .Replace("@Foto", organizador.foto)
                             .Replace("@Clave", organizador.clave);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }

        public static bool DeleteOrganizador(string organizador)
        {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "DELETE FROM proyecto1.organizador WHERE Usuario_Org ='@Organizador'";

                query = query.Replace("@Organizador", organizador);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
    }
}
