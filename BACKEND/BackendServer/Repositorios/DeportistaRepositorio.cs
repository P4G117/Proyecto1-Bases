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
    }
}
