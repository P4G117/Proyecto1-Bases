using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql;
using BackendServer.Models;
using BackendServer.Repositorios;

namespace BackendServer.Repositorios
{
    public class OrganizadorRepositorio
    {
        //Obtener todos los Organizadores
        public static List<Organizador> GetAllOrganizadores()
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT O.Usuario_org, O.Primer_Nombre, O.Apellido1, O.Apellido2, " +
                    "O.FecNac, O.Nacionalidad, O.Foto, O.Clave " +
                    "FROM proyecto1.organizador AS O";

                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Organizador> listaOrganizadores = new List<Organizador>();

                    while (reader.Read())
                    {
                        Organizador organizador = null;
                        organizador = new Organizador();
                        organizador.usuarioorg = reader.GetValue(0).ToString();
                        organizador.primernombre = reader.GetValue(1).ToString();
                        organizador.apellido1 = reader.GetValue(2).ToString();
                        organizador.apellido2 = reader.GetValue(3).ToString();
                        organizador.fecnac = reader.GetValue(4).ToString();
                        organizador.nacionalidad = reader.GetValue(5).ToString();
                        organizador.foto = reader.GetValue(6).ToString();
                        organizador.clave = reader.GetValue(7).ToString();

                        listaOrganizadores.Add(organizador);
                    }

                    return listaOrganizadores;
                }
            }

        }
        //Obtener a un Organizador 
        public static List<Organizador> GetOrganizador(string usuario_org)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                string query = "SELECT O.Usuario_org, O.Primer_Nombre, O.Apellido1, O.Apellido2, " +
                    "O.FecNac, O.Nacionalidad, O.Foto, O.Clave " +
                    "FROM proyecto1.organizador AS O " +
                    "WHERE Usuario_Org = '@Usuario'";

                query = query.Replace("@Usuario", usuario_org);
                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Organizador> listaOrganizadores = new List<Organizador>();

                    while (reader.Read())
                    {
                        Organizador organizador = null;
                        organizador = new Organizador();
                        organizador.usuarioorg = reader.GetValue(0).ToString();
                        organizador.primernombre = reader.GetValue(1).ToString();
                        organizador.apellido1 = reader.GetValue(2).ToString();
                        organizador.apellido2 = reader.GetValue(3).ToString();
                        organizador.fecnac = reader.GetValue(4).ToString();
                        organizador.nacionalidad = reader.GetValue(5).ToString();
                        organizador.foto = reader.GetValue(6).ToString();
                        organizador.clave = reader.GetValue(7).ToString();

                        listaOrganizadores.Add(organizador);
                    }

                    return listaOrganizadores;
                }
            }
        }
        //Agregar un Organizador
        public static bool PostOrganizador(Organizador organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "INSERT INTO proyecto1.organizador(Usuario_Org, " +
                    "Primer_Nombre,Apellido1, Apellido2, FecNac, Nacionalidad, Foto, Clave)" +
                    "VALUES('@Usuario', '@PrimerNombre', '@Apellido1', '@Apellido2', '@fecnac'," +
                    " '@Nacionalidad', '@Foto', '@Clave');";

                query = query.Replace("@Usuario", organizador.usuarioorg)
                             .Replace("@PrimerNombre", organizador.primernombre)
                             .Replace("@Apellido1", organizador.apellido1)
                             .Replace("@Apellido2", organizador.apellido2)
                             .Replace("@fecnac", organizador.fecnac)
                             .Replace("@Nacionalidad", organizador.nacionalidad)
                             .Replace("@Foto", organizador.foto)
                             .Replace("@Clave", organizador.clave);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
        //Actualizar un Organizador 
        public static bool UpdateOrganizador(string usuario_org, Organizador organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "UPDATE proyecto1.organizador SET Primer_Nombre = '@PrimerNombre', " +
                    "Apellido1 = '@Apellido1', Apellido2 = '@Apellido2', FecNac = '@fecnac', Nacionalidad = '@Nacionalidad', " +
                    "Foto = '@Foto', Clave = '@Clave' WHERE Usuario_Org = '@Usuario'";

                query = query.Replace("@Usuario", usuario_org)
                             .Replace("@PrimerNombre", organizador.primernombre)
                             .Replace("@Apellido1", organizador.apellido1)
                             .Replace("@Apellido2", organizador.apellido2)
                             .Replace("@fecnac", organizador.fecnac)
                             .Replace("@Nacionalidad", organizador.nacionalidad)
                             .Replace("@Foto", organizador.foto)
                             .Replace("@Clave", organizador.clave);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }
        //Eliminar un Organizador 
        public static bool DeleteOrganizador(string organizador)
        {

            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "DELETE FROM proyecto1.organizador WHERE Usuario_Org ='@Organizador'";

                query = query.Replace("@Organizador", organizador);
                var command = new NpgsqlCommand(query, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                return true;
            }
        }

        //Ver la Cantidad de Carreras Ligadas a un Organizador 
        public static List<Follow> GetTotalCarrerasOrg(string organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();
                
                string query = "SELECT count(nombre) AS Carreras" +
                    " FROM proyecto1.carrera AS A" +
                    " WHERE A.id_organizador = '@Organizador'; ";

                query = query.Replace("@Organizador", organizador);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Follow> listCarrera = new List<Follow>();

                    while (reader.Read())
                    {
                        Follow carrera = null;
                        carrera = new Follow();
                        carrera.follow = Convert.ToInt32(reader.GetValue(0));
                        
                        listCarrera.Add(carrera);
                    }

                    return listCarrera;
                }
            }

        }
        //Ver la Cantidad de Retos Ligados a un Organizador 
        public static List<Follow> GetTotalRetosOrg(string organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT count(nombre) AS Retos" +
                    " FROM proyecto1.reto AS A" +
                    " WHERE A.id_organizador = '@Organizador' ";

                query = query.Replace("@Organizador", organizador);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Follow> listReto = new List<Follow>();

                    while (reader.Read())
                    {
                        Follow reto = null;
                        reto = new Follow();
                        reto.follow = Convert.ToInt32(reader.GetValue(0));
                        
                        listReto.Add(reto);
                    }

                    return listReto;
                }
            }

        }
        //Ver la cantidad de los Grupos Ligados a un Organizador 
        public static List<Follow> GetTotalGruposDeOrg(string organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT count(nombre) AS Grupos" +
                    " FROM proyecto1.grupo AS A" +
                    " WHERE A.id_organizador = '@Organizador'; ";

                query = query.Replace("@Organizador", organizador);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Follow> listGrupo = new List<Follow>();

                    while (reader.Read())
                    {
                        Follow grupo = null;
                        grupo = new Follow();
                        grupo.follow = Convert.ToInt32(reader.GetValue(0));
                       
                        listGrupo.Add(grupo);
                    }

                    return listGrupo;
                }
            }

        }
        //Obtener las Carreras hechas por un Organizador 
        public static List<Carrera> TodasCarrerasOrg(string organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT A.id_carrera, A.id_organizador, A.nombre, A.fecha, A.recorrido, A.cuenta, A.costo, A.privacidad, A.tipo_actividad" +
                    " FROM proyecto1.carrera AS A" +
                    " WHERE A.id_organizador = '@Organizador'; ";

                query = query.Replace("@Organizador", organizador);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Carrera> listCarrera = new List<Carrera>();

                    while (reader.Read())
                    {
                        Carrera carreras = null;
                        carreras = new Carrera();
                        carreras.idcarrera = Convert.ToInt32(reader.GetValue(0));
                        carreras.idorganizador = reader.GetValue(1).ToString();
                        carreras.nombre = reader.GetValue(2).ToString();
                        carreras.fecha = reader.GetValue(3).ToString();
                        carreras.recorrido = reader.GetValue(4).ToString();
                        carreras.cuenta = Convert.ToInt64(reader.GetValue(5));
                        carreras.costo = Convert.ToInt64(reader.GetValue(6));
                        carreras.privacidad = Convert.ToBoolean(reader.GetValue(7));
                        carreras.tipoActividad = reader.GetValue(8).ToString();

                        listCarrera.Add(carreras);
                    }

                    return listCarrera;
                }
            }

        }
        //Obtener los Retos hechos por un Organizador 
        public static List<Reto> TodosRetosOrg(string organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT A.id_reto, A.nombre, A.periodo, A.privacidad, A.tipo_reto, A.tipo_actividad, A.id_organizador" +
                    " FROM proyecto1.reto AS A" +
                    " WHERE A.id_organizador = '@Organizador' ";

                query = query.Replace("@Organizador", organizador);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Reto> listReto = new List<Reto>();

                    while (reader.Read())
                    {
                        Reto reto = null;
                        reto = new Reto();
                        reto.IdReto = Convert.ToInt32(reader.GetValue(0));
                        reto.Nombre = reader.GetValue(1).ToString();
                        reto.Periodo = reader.GetValue(2).ToString();
                        reto.Privacidad = Convert.ToBoolean(reader.GetValue(3));
                        reto.TipoReto = reader.GetValue(4).ToString();
                        reto.TipoActividad = reader.GetValue(5).ToString();
                        reto.IdOrganizador = reader.GetValue(6).ToString();

                        listReto.Add(reto);
                    }

                    return listReto;
                }
            }

        }
        //Obtener los Grupos hechos por un Organizador 
        public static List<Grupo> TodosGruposOrg(string organizador)
        {
            Connexion connString = new Connexion();

            using (var conn = new NpgsqlConnection(connString.conexion))
            {

                Console.Out.WriteLine("Opening connection");
                conn.Open();

                string query = "SELECT A.ID_Grupo, A.Nombre, A.Administrador" +
                    " FROM proyecto1.grupo AS A" +
                    " WHERE A.Administrador = '@Organizador'; ";

                query = query.Replace("@Organizador", organizador);


                using (var command = new NpgsqlCommand(query, conn))
                {

                    var reader = command.ExecuteReader();
                    List<Grupo> listGrupo = new List<Grupo>();

                    while (reader.Read())
                    {
                        Grupo grupos = null;
                        grupos = new Grupo();
                        grupos.idgrupo = Convert.ToInt32(reader.GetValue(0));
                        grupos.nombre = reader.GetValue(1).ToString();
                        grupos.administrador = reader.GetValue(2).ToString();

                        listGrupo.Add(grupos);
                    }

                    return listGrupo;
                }
            }

        }
    }
}
