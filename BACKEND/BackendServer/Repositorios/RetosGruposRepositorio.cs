using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BackendServer.Models;
using System.Globalization;

namespace BackendServer.Repositorios
{
    public class RetosGruposRepositorio
    {
        public static List<RetosSegunGrupo> GetRetosGrupos(string deportista)
        {
            string connString = "Host=localhost;Port=5432;Database=StraviaTec;Username=postgres;Password=azofeifa1171290;";

            using (var conn = new NpgsqlConnection(connString))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT A.nombre, W.nombre, periodo, tipo_reto, tipo_actividad" +
                    " FROM" +
                    " (((proyecto1.deportista_grupo AS J RIGHT JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)" +
                    " RIGHT JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)" +
                    " RIGHT JOIN proyecto1.grupo_reto AS P ON P.id_grupo = A.id_grupo)" +
                    " RIGHT JOIN proyecto1.reto AS W ON P.id_reto = W.id_reto" +
                    " WHERE D.usuario_dep = '@Deportista'";

                query = query.Replace("@Deportista", deportista);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<RetosSegunGrupo> listRetosSegunGrupo = new List<RetosSegunGrupo>();

                    while (reader.Read())
                    {
                        RetosSegunGrupo retosSegunGrupo = null;
                        retosSegunGrupo = new RetosSegunGrupo();
                        retosSegunGrupo.nombregrupo = reader.GetValue(0).ToString();
                        retosSegunGrupo.nombrereto = reader.GetValue(1).ToString();
                        retosSegunGrupo.periodo = reader.GetValue(2).ToString();
                        retosSegunGrupo.tiporeto = reader.GetValue(3).ToString();
                        retosSegunGrupo.tipoactividad = reader.GetValue(4).ToString();
 
                        listRetosSegunGrupo.Add(retosSegunGrupo);
                    }

                    return listRetosSegunGrupo;
                }
            }

        }
    }
}
