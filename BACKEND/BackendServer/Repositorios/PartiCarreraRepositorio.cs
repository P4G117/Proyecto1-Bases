using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BackendServer.Models;
using BackendServer.Repositorios;
namespace BackendServer.Repositorios
{
    public class PartiCarreraRepositorio
    {
        public static List<ParticipantesCarrera> GetParticipantesCarrera(string carrera)
        {
            //string connString = "Host=localhost;Port=5432;Database=StraviaTec;Username=postgres;Password=azofeifa1171290;";
            Connexion connexion = new Connexion();

            using (var conn = new NpgsqlConnection(connexion.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT D.primer_nombre, D.apellido1, D.apellido2, date_part('year',age(D.fecnac)) AS Edad, I.categoria" +
                    " FROM" +
                    " (proyecto1.inscripcion AS I RIGHT JOIN proyecto1.deportista AS D ON I.usuario_dep = D.usuario_dep)," +
                    " proyecto1.carrera AS C" +
                    " WHERE I.id_carrera = C.id_carrera AND C.nombre = '@Carrera'" +
                    " ORDER BY I.categoria; ";

                query = query.Replace("@Carrera", carrera);

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<ParticipantesCarrera> listParticipantesCarrera = new List<ParticipantesCarrera>();

                    while (reader.Read())
                    {
                        ParticipantesCarrera participantesCarrera = null;
                        participantesCarrera = new ParticipantesCarrera();
                        participantesCarrera.primer_nombre = reader.GetValue(0).ToString();
                        participantesCarrera.apellido1 = reader.GetValue(1).ToString();
                        participantesCarrera.apellido2 = reader.GetValue(2).ToString();
                        participantesCarrera.edad = reader.GetValue(3).ToString();
                        participantesCarrera.categoria = reader.GetValue(4).ToString();

                        listParticipantesCarrera.Add(participantesCarrera);
                    }

                    return listParticipantesCarrera;
                }
            }

        }
    }
}
