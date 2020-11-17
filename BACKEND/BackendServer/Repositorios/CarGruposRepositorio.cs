using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BackendServer.Models;
using System.Globalization;
using BackendServer.Repositorios;

namespace BackendServer.Repositorios
{
    public class CarGruposRepositorio
    {
        public static List<CarrerasSegunGrupo> GetCarrerasSegunGrupo(string deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                
                string query = "SELECT A.nombre, W.nombre, fecha, recorrido, cuenta, costo, tipo_actividad" +
                    " FROM" +
                    " (((proyecto1.deportista_grupo AS J RIGHT JOIN proyecto1.deportista AS D ON J.usuario_dep = D.usuario_dep)" +
                    " RIGHT JOIN proyecto1.grupo AS A ON J.id_grupo = A.id_grupo)" +
                    " RIGHT JOIN proyecto1.grupo_carrera AS P ON P.id_grupo = A.id_grupo)" +
                    " RIGHT JOIN proyecto1.carrera AS W ON P.id_carrera = W.id_carrera" +
                    " WHERE D.usuario_dep = '@Deportista'; ";

                query = query.Replace("@Deportista", deportista);

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<CarrerasSegunGrupo> listCarrerasSegunGrupo = new List<CarrerasSegunGrupo>();

                    while (reader.Read())
                    {
                        CarrerasSegunGrupo carrerasSegunGrupo = null;
                        carrerasSegunGrupo = new CarrerasSegunGrupo();
                        carrerasSegunGrupo.nombregrupo = reader.GetValue(0).ToString();
                        carrerasSegunGrupo.nombrecarrera = reader.GetValue(1).ToString();
                        carrerasSegunGrupo.fecha = reader.GetValue(2).ToString();
                        carrerasSegunGrupo.recorrido = reader.GetValue(3).ToString();
                        carrerasSegunGrupo.cuenta = Convert.ToInt64(reader.GetValue(4));
                        carrerasSegunGrupo.costo = Convert.ToInt32(reader.GetValue(5));
                        carrerasSegunGrupo.tipoActividad = reader.GetValue(6).ToString();

                        listCarrerasSegunGrupo.Add(carrerasSegunGrupo);
                    }

                    return listCarrerasSegunGrupo;
                }
            }

        }
    }
}
