using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BackendServer.Models;

namespace BackendServer.Repositorios
{
    public class PosiCarreraRepositorio
    {
        //Ver las Posiciones de una Carrera
        public static List<PosicionesCarrera> GetPosicionesCarrera(string carrera)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT D.primer_nombre, D.apellido1, D.apellido2, date_part('year',age(D.fecnac)) AS Edad, A.duracion, I.categoria" +
                    " FROM" +
                    " ((proyecto1.inscripcion AS I RIGHT JOIN proyecto1.deportista AS D ON I.usuario_dep = D.usuario_dep)" +
                    " RIGHT JOIN proyecto1.actividad AS A ON A.id_deportista = D.usuario_dep)," +
                    " proyecto1.carrera AS C" +
                    " WHERE I.id_carrera = C.id_carrera AND C.nombre = '@Carrera' AND A.nombreactividad = '@Carrera'" +
                    " ORDER BY A.duracion; ";

                query = query.Replace("@Carrera", carrera);

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<PosicionesCarrera> listPosicionesCarrera = new List<PosicionesCarrera>();

                    while (reader.Read())
                    {
                        PosicionesCarrera posicionesCarrera = null;
                        posicionesCarrera = new PosicionesCarrera();
                        posicionesCarrera.primer_nombre = reader.GetValue(0).ToString();
                        posicionesCarrera.apellido1 = reader.GetValue(1).ToString();
                        posicionesCarrera.apellido2 = reader.GetValue(2).ToString();
                        posicionesCarrera.edad = reader.GetValue(3).ToString();
                        posicionesCarrera.duracion = reader.GetValue(4).ToString();
                        posicionesCarrera.categoria = reader.GetValue(5).ToString();

                        listPosicionesCarrera.Add(posicionesCarrera);
                    }

                    return listPosicionesCarrera;
                }
            }

        }
    }
}
