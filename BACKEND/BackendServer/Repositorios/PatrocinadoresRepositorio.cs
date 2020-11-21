using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendServer.Models;
using System.Globalization;
using BackendServer.Repositorios;
using Npgsql;

namespace BackendServer.Repositorios
{
    public class PatrocinadoresRepositorio
    {
        public static List<Patrocinadores> PatrocinadoresCarrera(int carrera)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT P.nombre " +
                    "FROM (proyecto1.patrocinador_carrera AS C JOIN proyecto1.patrocinador AS P ON C.id_patrocinador = P.id_patrocinador) " +
                    "WHERE C.id_carrera = @ID_Carrera;";

                query = query.Replace("@ID_Carrera", carrera.ToString());

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Patrocinadores> listaPatrocinadores = new List<Patrocinadores>();

                    while (reader.Read())
                    {
                        Patrocinadores patrocinador = null;
                        patrocinador = new Patrocinadores();
                        patrocinador.nombrepatrocinador = reader.GetValue(0).ToString();

                        listaPatrocinadores.Add(patrocinador);
                    }

                    return listaPatrocinadores;
                }
            }

        }

        public static List<Patrocinadores> PatrocinadorReto(int reto)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT P.nombre " +
                    "FROM(proyecto1.patrocinador_reto AS R JOIN proyecto1.patrocinador AS P ON R.id_patrocinador = P.id_patrocinador) " +
                    "WHERE R.id_reto = @ID_Reto; ";

                query = query.Replace("@ID_Reto", reto.ToString());

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Patrocinadores> listaPatrocinadores = new List<Patrocinadores>();

                    while (reader.Read())
                    {
                        Patrocinadores patrocinador = null;
                        patrocinador = new Patrocinadores();
                        patrocinador.nombrepatrocinador = reader.GetValue(0).ToString();

                        listaPatrocinadores.Add(patrocinador);
                    }

                    return listaPatrocinadores;
                }
            }

        }
    }
}
