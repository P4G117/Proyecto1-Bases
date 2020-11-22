using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using BackendServer.Models;
using BackendServer.Repositorios;

namespace BackendServer.Repositorios
{
    public class InscripcionesRepositorio
    {
        //Ingresar a un Grupo - Deportista
        public static bool InscripcionGrupo(DeportistaGrupo deportista)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.deportista_grupo(usuario_dep, " +
                    "id_grupo)" +
                    " VALUES('@Usuario', @IdGrupo); ";

                query = query.Replace("@Usuario", deportista.usuariodep)
                             .Replace("@IdGrupo", deportista.idgrupo.ToString());

                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }

        public static List<Inscripcion> getInscripcionCarrera()
        {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT I.ID_Inscripcion, I.ID_Carrera, I.Usuario_dep, I.Comprobante, I.Categoria " +
                    "FROM proyecto1.inscripcion AS I";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Inscripcion> listainscripcion = new List<Inscripcion>();

                    while (reader.Read())
                    {
                        Inscripcion inscripcion = null;
                        inscripcion = new Inscripcion();
                        inscripcion.ID_Inscripcion = Convert.ToInt32(reader.GetValue(0));
                        inscripcion.ID_Carrera = Convert.ToInt32(reader.GetValue(1));
                        inscripcion.Usuario_Dep = reader.GetValue(2).ToString();
                        inscripcion.Comprobante = reader.GetValue(3).ToString();
                        inscripcion.Categoria = reader.GetValue(4).ToString();

                        listainscripcion.Add(inscripcion);
                    }

                    return listainscripcion;
                }
            }
        }

        public static bool InscripcionCarrera(Inscripcion carrera)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.inscripcion(ID_Carrera, Usuario_Dep, Comprobante, Categoria) VALUES (@ID_Carrera,'@Usuario_Dep','@Comprobante','@Categoria');";

                query = query.Replace("@ID_Carrera", carrera.ID_Carrera.ToString())
                             .Replace("@Usuario_Dep", carrera.Usuario_Dep)
                             .Replace("@Comprobante", carrera.Comprobante)
                             .Replace("@Categoria", carrera.Categoria);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }

        public static List<DeportistaReto> getInscripcionReto()
        {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT R.Usuario_dep, R.ID_Reto " +
                    "FROM proyecto1.deportista_reto AS R";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<DeportistaReto> listareto = new List<DeportistaReto>();

                    while (reader.Read())
                    {
                        DeportistaReto reto = null;
                        reto = new DeportistaReto();
                        reto.usuariodep = reader.GetValue(0).ToString();
                        reto.idreto = Convert.ToInt32(reader.GetValue(1));


                        listareto.Add(reto);
                    }

                    return listareto;
                }
            }
        }

        public static bool InscripcionReto(DeportistaReto reto)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.deportista_reto(usuario_dep, id_reto) VALUES ('@Usuario_Dep', @ID_Reto)";

                query = query.Replace("@Usuario_Dep", reto.usuariodep)
                             .Replace("@ID_Reto", reto.idreto.ToString());

                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
    }
}
