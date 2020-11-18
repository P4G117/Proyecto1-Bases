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
    public class CarPublicasRepositorio
    {
        public static List<CarrerasPublicas> GetCarrerasPublicas()
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT id_carrera,nombre, recorrido, fecha, cuenta, costo, tipo_actividad FROM proyecto1.carrera WHERE proyecto1.carrera.privacidad = FALSE";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<CarrerasPublicas> listCarrerasPublicas = new List<CarrerasPublicas>();

                    while (reader.Read())
                    {
                        CarrerasPublicas carrerasPublicas = null;
                        carrerasPublicas = new CarrerasPublicas();
                        carrerasPublicas.idcarrera = Convert.ToInt32(reader.GetValue(0));
                        carrerasPublicas.nombre = reader.GetValue(1).ToString();
                        carrerasPublicas.fecha = reader.GetValue(2).ToString();
                        carrerasPublicas.recorrido = reader.GetValue(3).ToString();
                        carrerasPublicas.cuenta = Convert.ToInt64(reader.GetValue(4));
                        carrerasPublicas.costo = Convert.ToInt32(reader.GetValue(5));
                        carrerasPublicas.tipoActividad = reader.GetValue(6).ToString();
                        
                        listCarrerasPublicas.Add(carrerasPublicas);
                    }

                    return listCarrerasPublicas;
                }
            }

        }
    }
}
