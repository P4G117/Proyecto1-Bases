using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BackendServer.Models;

namespace BackendServer.Repositorios
{
    public class ResultCarreraRepositorio
    {
        public static List<ResultadoCarrera> GetResultadoCarrera(string carrera)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT D.primer_nombre, D.apellido1, D.apellido2, A.duracion, I.categoria" +
                    " FROM" +
                    " ((proyecto1.inscripcion AS I RIGHT JOIN proyecto1.deportista AS D ON I.usuario_dep = D.usuario_dep)" +
                    " RIGHT JOIN proyecto1.actividad AS A ON A.id_deportista = D.usuario_dep)," +
                    " proyecto1.carrera AS C" +
                    " WHERE I.id_carrera = C.id_carrera AND C.nombre = '@Carrera' AND A.nombreactividad = '@Carrera'" +
                    " ORDER BY A.duracion ASC; ";

                query = query.Replace("@Carrera", carrera);

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<ResultadoCarrera> listResultadoCarrera = new List<ResultadoCarrera>();

                    while (reader.Read())
                    {
                        ResultadoCarrera resultadoCarrera = null;
                        resultadoCarrera = new ResultadoCarrera();
                        resultadoCarrera.primer_nombre = reader.GetValue(0).ToString();
                        resultadoCarrera.apellido1 = reader.GetValue(1).ToString();
                        resultadoCarrera.apellido2 = reader.GetValue(2).ToString();
                        resultadoCarrera.duracion= reader.GetValue(3).ToString();
                        resultadoCarrera.categoria = reader.GetValue(4).ToString();

                        listResultadoCarrera.Add(resultadoCarrera);
                    }

                    return listResultadoCarrera;
                }
            }

        }
    }
}
