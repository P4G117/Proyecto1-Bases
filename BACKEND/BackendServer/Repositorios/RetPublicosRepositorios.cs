﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BackendServer.Models;
using System.Globalization;

namespace BackendServer.Repositorios
{
    public class RetPublicosRepositorios
    {
        public static List<RetosPublicos> GetRetosPublicos()
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                //, A.duracion
                string query = "SELECT id_reto,nombre,periodo,tipo_reto,tipo_actividad FROM proyecto1.reto WHERE proyecto1.reto.privacidad = FALSE";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<RetosPublicos> listRetosPublicos = new List<RetosPublicos>();

                    while (reader.Read())
                    {
                        RetosPublicos retosPublicos = null;
                        retosPublicos = new RetosPublicos();
                        retosPublicos.idreto = Convert.ToInt32(reader.GetValue(0));
                        retosPublicos.nombre = reader.GetValue(1).ToString();
                        retosPublicos.periodo = reader.GetValue(2).ToString();
                        retosPublicos.tipo_reto = reader.GetValue(3).ToString();
                        retosPublicos.tipo_actividad = reader.GetValue(4).ToString();

                        listRetosPublicos.Add(retosPublicos);
                    }

                    return listRetosPublicos;
                }
            }

        }
    }
}
