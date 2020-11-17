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

        public static List<Deportista> GetActividadesAmigos(string deportista)
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
                        deportistas.PrimerNombre = reader.GetValue(0).ToString();
                        deportistas.Apellido1 = reader.GetValue(1).ToString();
                        deportistas.Apellido2 = reader.GetValue(2).ToString();
                        deportistas.Fecnac = reader.GetValue(3).ToString();
                        deportistas.Nacionalidad = reader.GetValue(4).ToString();
                        deportistas.Foto = reader.GetValue(5).ToString();
                        deportistas.Clave = reader.GetValue(6).ToString();

                        listadeportistas.Add(deportistas);
                    }

                    return listadeportistas;
                }
            }

        }
    }
}
