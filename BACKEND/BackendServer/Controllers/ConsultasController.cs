using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendServer.Models;
using BackendServer.Repositorios;

namespace BackendServer.Controllers
{
    public class ConsultasController
    {
        //Para traerse a todos los Amigos con las Actividades
        //URL Ejemplo: https://localhost:44317/GetActiAmigos/adri45s
        [HttpGet]
        [Route("/api/GetActiAmigos/{deportista}")]
        public IEnumerable<ActividadesAmigos> Get(string deportista)
        {
            return ActividadesAmigosRepositorio.GetActividadesAmigos(deportista);
        }
        //Para ver a todos los Deportistas que no sean Amigos 
        //URL Ejemplo: https://localhost:44317/GetPosAmigos/adri45s
        [HttpGet]
        [Route("/api/GetPosAmigos/{deportista}")]
        public IEnumerable<PosiblesAmigos> Get1(string deportista)
        {
            return PosAmigosReporsitorio.GetPosiblesAmigos(deportista);
        }
        //Buscar solo por Nombre
        //URL Ejemplo1: https://localhost:44317/GetBusquedaNombre/adri45s/R
        //URL Ejemplo2: https://localhost:44317/GetBusquedaNombre/adri45s/Roc 
        //Al buscar se tiene que ser explicito, distingue entre Mayusculas y Minusculas
        [HttpGet("{deportista}/{buscar}")]
        [Route("/api/GetBusquedaNombre/{deportista}/{buscar}")]
        public IEnumerable<BusquedaPersonas> GetBusquedaNombre(string deportista, string buscar)
        {
            return BuscarXNombreRepositorio.GetBusquedaNombre(deportista, buscar);
        }
        //Buscar por Nombre y Primer Apellido
        //URL Ejemplo: https://localhost:44317/GetBusquedaNombreApe/adri45s/R/B
        //Al buscar se tiene que ser explicito, distingue entre Mayusculas y Minusculas
        [HttpGet("{deportista}/{busc1}/{busc2}")]
        [Route("/api/GetBusquedaNombreApe/{deportista}/{busc1}/{busc2}")]
        public IEnumerable<BusquedaPersonas> GetBusquedaNombreApe(string deportista, string busc1, string busc2)
        {
            return BuscNomApeRepositorio.GetBusquedaNombreApe(deportista, busc1, busc2);
        }
        //Buscar por Nombre y los Apellidos 
        //URL Ejemplo: https://localhost:44317/GetBusquedaNombreApes/adri45s/R/B/V
        //Al buscar se tiene que ser explicito, distingue entre Mayusculas y Minusculas
        [HttpGet("{deportista}/{busc1}/{busc2}/{busc3}")]
        [Route("/api/GetBusquedaNombreApes/{deportista}/{busc1}/{busc2}/{busc3}")]
        public IEnumerable<BusquedaPersonas> GetBusquedaNombreApes(string deportista, string busc1, string busc2, string busc3)
        {
            return BuscNomApesRepositorio.GetBusquedaNombreApes(deportista, busc1, busc2, busc3);
        }
        //Mostrar todas las carreras que son Publicas 
        //URL Ejemplo: https://localhost:44317/GetCarrerasPublicas
        [HttpGet]
        [Route("/api/GetCarrerasPublicas")]
        public IEnumerable<CarrerasPublicas> GetCarrerasPublicas()
        {
            return CarPublicasRepositorio.GetCarrerasPublicas();
        }
        //Mostrar todos los Retos que son Publicos
        //URL Ejemplo: https://localhost:44317/GetRetosPublicos
        [HttpGet]
        [Route("/api/GetRetosPublicos")]
        public IEnumerable<RetosPublicos> GetRetosPublicos()
        {
            return RetPublicosRepositorios.GetRetosPublicos();
        }
        //Ver los Retos que estarían disponibles según el Grupo en que este Asociado
        //URL Ejemplo: https://localhost:44317/GetRetosGrupos/adri45s
        [HttpGet]
        [Route("/api/GetRetosGrupos/{deportista}")]
        public IEnumerable<RetosSegunGrupo> GetRetosGrupos(string deportista)
        {
            return RetosGruposRepositorio.GetRetosGrupos(deportista);
        }
        //Ver las Carreras que estarían disponibles según el Grupo en que este Asociado
        //URL Ejemplo: https://localhost:44317/GetCarrerasSegunGrupo/adri45s
        [HttpGet]
        [Route("/api/GetCarrerasSegunGrupo/{deportista}")]
        public IEnumerable<CarrerasSegunGrupo> GetCarrerasSegunGrupo(string deportista)
        {
            return CarGruposRepositorio.GetCarrerasSegunGrupo(deportista);
        }
        //Ver el Resultado de una Carrera en la que estaba Inscrito
        //URL Ejemplo: https://localhost:44317/GetResultadoCarrera/Clasica%20Palmarin
        [HttpGet("{carrera}")]
        [Route("/api/GetResultadoCarrera/{carrera}")]
        public IEnumerable<ResultadoCarrera> GetResultadoCarrera(string carrera)
        {
            return ResultCarreraRepositorio.GetResultadoCarrera(carrera);
        }
        //Ver todos los participante que hay Inscritos para una Carrera: Reporte
        //URL Ejemplo: https://localhost:44317/GetParticipantesCarrera/Clasica%20Palmarin
        [HttpGet("{carrera}")]
        [Route("/api/GetParticipantesCarrera/{carrera}")]
        public IEnumerable<ParticipantesCarrera> GetParticipantesCarrera(string carrera)
        {
            return PartiCarreraRepositorio.GetParticipantesCarrera(carrera);
        }
        //Ver las posiciones de una Carrera: Reporte
        //URL Ejemplo:https://localhost:44317/GetPosicionesCarrera/Clasica%20Palmarin
        //No se Agrupan 
        [HttpGet("{carrera}")]
        [Route("/api/GetPosicionesCarrera/{carrera}")]
        public IEnumerable<PosicionesCarrera> GetPosicionesCarrera(string carrera)
        {
            return PosiCarreraRepositorio.GetPosicionesCarrera(carrera);
        }
        //Ver cuantos Amigos tiene un Deportista - Following 
        [HttpGet]
        [Route("/api/GetFollowing/{deportista}")]
        public IEnumerable<Follow> GetFollowing(string deportista)
        {
            return PosAmigosReporsitorio.GetFollowing(deportista);
        }
        //Ver cuantos Seguidores tiene un Deportista - Followers 
        [HttpGet]
        [Route("/api/GetFollowers/{deportista}")]
        public IEnumerable<Follow> GetFollowers(string deportista)
        {
            return PosAmigosReporsitorio.GetFollowers(deportista);
        }
        //Ver cuantas Actividades tiene un Deportista
        [HttpGet]
        [Route("/api/GetTotalActividades/{deportista}")]
        public IEnumerable<Follow> GetTotalActividades(string deportista)
        {
            return PosAmigosReporsitorio.GetTotalActividades(deportista);
        }
        //Obtener la Edad de un Deportista
        [HttpGet]
        [Route("/api/GetEdadDeportista/{deportista}")]
        public IEnumerable<Follow> GetEdadDeportista(string deportista)
        {
            return PosAmigosReporsitorio.GetEdadDeportista(deportista);
        }
        //Ver los Grupos Disponibles de los que Todavia no forma Parte el Deportista
        [HttpGet]
        [Route("/api/GetGruposDisponibles/{deportista}")]
        public IEnumerable<GrupoBusqueda> GetGruposDisponibles(string deportista)
        {
            return GrupoRepositorio.GetGruposDisponibles(deportista);
        }
        //Buscar Grupos por Nombre - De los que todavia no Forma Parte
        [HttpGet]//("{depor}/{buscgrupo}")
        [Route("/api/BusquedaGruposDisponibles/{depor}/{buscgrupo}")]
        public IEnumerable<GrupoBusqueda> BusquedaGruposDisponibles(string deportista, string buscar)
        {
            return GrupoRepositorio.BusquedaGruposDisponibles(deportista, buscar);
        }
        //Ver las Carreras en que esta Inscrito un Deportista 
        [HttpGet]
        [Route("/api/CarInscritasDep/{deportista}")]
        public IEnumerable<GrupoBusqueda> CarInscritasDep(string deportista)
        {
            return DeportistaRepositorio.CarInscritasDep(deportista);
        }
        //Ver los Retos en que esta Inscrito un Deportista 
        [HttpGet]
        [Route("/api/RetInscritosDep/{deportista}")]
        public IEnumerable<GrupoBusqueda> RetInscritosDep(string deportista)
        {
            return DeportistaRepositorio.RetInscritosDep(deportista);
        }
        //Ver la Cantidad de Carreras Ligadas a un Organizador 
        [HttpGet]
        [Route("/api/GetTotalCarrerasOrg/{organizador}")]
        public IEnumerable<Follow> GetTotalCarrerasOrg(string organizador)
        {
            return OrganizadorRepositorio.GetTotalCarrerasOrg(organizador);
        }
        //Ver la Cantidad de Retos Ligados a un Organizador 
        [HttpGet]
        [Route("/api/GetTotalRetosOrg/{organizador}")]
        public IEnumerable<Follow> GetTotalRetosOrg(string organizador)
        {
            return OrganizadorRepositorio.GetTotalRetosOrg(organizador);
        }
        //Ver los Grupos Ligados a un Organizador 
        [HttpGet]
        [Route("/api/GetTotalGruposDeOrg/{organizador}")]
        public IEnumerable<Follow> GetTotalGruposDeOrg(string organizador)
        {
            return OrganizadorRepositorio.GetTotalGruposDeOrg(organizador);
        }
        //Carreras hechas por un Organizador 
        [HttpGet]
        [Route("/api/TodasCarrerasOrg/{organizador}")]
        public IEnumerable<Carrera> TodasCarrerasOrg(string organizador)
        {
            return OrganizadorRepositorio.TodasCarrerasOrg(organizador);
        }
        //Retos hechos por un Organizador 
        [HttpGet]
        [Route("/api/TodosRetosOrg/{organizador}")]
        public IEnumerable<Reto> TodosRetosOrg(string organizador)
        {
            return OrganizadorRepositorio.TodosRetosOrg(organizador);
        }
        //Grupo hechos por un Organizador 
        [HttpGet]
        [Route("/api/TodosGruposOrg/{organizador}")]
        public IEnumerable<Grupo> TodosGruposOrg(string organizador)
        {
            return OrganizadorRepositorio.TodosGruposOrg(organizador);
        }
        //Ver lo Grupos a los que Pertenece un Deportista
        [HttpGet]
        [Route("/api/MisGruposDep/{deportista}")]
        public IEnumerable<Grupo> MisGruposDep(string deportista)
        {
            return DeportistaRepositorio.MisGruposDep(deportista);
        }

        //Retorna los nombres de los patrocinadores de una carrera
        [HttpGet]
        [Route("api/patrocinadoresCarreras/{idCarrera}")]
        public IEnumerable<Patrocinadores> PatrocinadorCarrera(int idCarrera)
        {
            return PatrocinadoresRepositorio.PatrocinadoresCarrera(idCarrera);
        }

        //Retorna los nombres de los patrocinadores de un reto
        [HttpGet]
        [Route("api/patrocinadoresRetos/{idreto}")]
        public IEnumerable<Patrocinadores> PatrocinadorReto(int idreto)
        {
            return PatrocinadoresRepositorio.PatrocinadorReto(idreto);
        }

        //
        [HttpGet]
        [Route("api/getInscripcionCarrera")]
        public IEnumerable<Inscripcion> getInscripcionCarrera()
        {
            return InscripcionesRepositorio.getInscripcionCarrera();
        }

        [HttpGet]
        [Route("api/getInscripcionReto")]
        public IEnumerable<DeportistaReto> getInscripcionReto()
        {
            return InscripcionesRepositorio.getInscripcionReto();
        }

    }
}
