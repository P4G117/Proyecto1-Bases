﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using BackendServer.Models;

namespace BackendServer.Repositorios
{
    public class BuscNomApeRepositorio
    {
        public static List<BusquedaPersonas> GetBusquedaNombreApe(string deportista, string busc1, string busc2)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2" +
                    " FROM proyecto1.deportista AS D" +
                    " WHERE D.primer_nombre LIKE '@Buscar1%' AND D.apellido1 LIKE '@Buscar2%'" +
                    " EXCEPT" +
                    " SELECT D.usuario_dep, D.primer_nombre, D.apellido1, D.apellido2" +
                    " FROM" +
                    " (proyecto1.amigo AS J RIGHT JOIN proyecto1.deportista AS D ON J.amigo = D.usuario_dep)" +
                    " WHERE J.deportista = '@Deportista'";

                query = query.Replace("@Deportista", deportista);
                query = query.Replace("@Buscar1", busc1);
                query = query.Replace("@Buscar2", busc2);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<BusquedaPersonas> listBusquedaPersonas = new List<BusquedaPersonas>();

                    while (reader.Read())
                    {
                        BusquedaPersonas busquedaPersonas = null;
                        busquedaPersonas = new BusquedaPersonas();
                        busquedaPersonas.usuariodep = reader.GetValue(0).ToString();
                        busquedaPersonas.primer_nombre = reader.GetValue(1).ToString();
                        busquedaPersonas.apellido1 = reader.GetValue(2).ToString();
                        busquedaPersonas.apellido2 = reader.GetValue(3).ToString();

                        listBusquedaPersonas.Add(busquedaPersonas);
                    }

                    return listBusquedaPersonas;
                }
            }

        }
    }
}
