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
        [Route("GetActiAmigos/{deportista}")]
        public IEnumerable<ActividadesAmigos> Get(string deportista)
        {
            return ActividadesAmigosRepositorio.GetActividadesAmigos(deportista);
        }
        //Para ver a todos los Deportistas que no sean Amigos 
        //URL Ejemplo: https://localhost:44317/GetPosAmigos/adri45s
        [HttpGet]
        [Route("GetPosAmigos/{deportista}")]
        public IEnumerable<PosiblesAmigos> Get1(string deportista)
        {
            return PosAmigosReporsitorio.GetPosiblesAmigos(deportista);
        }
        //Buscar solo por Nombre
        //URL Ejemplo1: https://localhost:44317/GetBusquedaNombre/adri45s/R
        //URL Ejemplo2: https://localhost:44317/GetBusquedaNombre/adri45s/Roc 
        //Al buscar se tiene que ser explicito, distingue entre Mayusculas y Minusculas
        [HttpGet("{deportista}/{buscar}")]
        [Route("GetBusquedaNombre/{deportista}/{buscar}")] 
        public IEnumerable<BusquedaPersonas> GetBusquedaNombre(string deportista, string buscar)
        {
            return BuscarXNombreRepositorio.GetBusquedaNombre(deportista, buscar);
        }
        //Buscar por Nombre y Primer Apellido
        //URL Ejemplo: https://localhost:44317/GetBusquedaNombreApe/adri45s/R/B
        //Al buscar se tiene que ser explicito, distingue entre Mayusculas y Minusculas
        [HttpGet("{deportista}/{busc1}/{busc2}")]
        [Route("GetBusquedaNombreApe/{deportista}/{busc1}/{busc2}")]
        public IEnumerable<BusquedaPersonas> GetBusquedaNombreApe(string deportista, string busc1, string busc2)
        {
            return BuscNomApeRepositorio.GetBusquedaNombreApe(deportista, busc1, busc2);
        }
        //Buscar por Nombre y los Apellidos 
        //URL Ejemplo: https://localhost:44317/GetBusquedaNombreApes/adri45s/R/B/V
        //Al buscar se tiene que ser explicito, distingue entre Mayusculas y Minusculas
        [HttpGet("{deportista}/{busc1}/{busc2}/{busc3}")]
        [Route("GetBusquedaNombreApes/{deportista}/{busc1}/{busc2}/{busc3}")]
        public IEnumerable<BusquedaPersonas> GetBusquedaNombreApes(string deportista, string busc1, string busc2, string busc3)
        {
            return BuscNomApesRepositorio.GetBusquedaNombreApes(deportista, busc1, busc2, busc3);
        }
        //Mostrar todas las carreras que son Publicas 
        //URL Ejemplo: https://localhost:44317/GetCarrerasPublicas
        [HttpGet]
        [Route("GetCarrerasPublicas")]
        public IEnumerable<CarrerasPublicas> GetCarrerasPublicas()
        {
            return CarPublicasRepositorio.GetCarrerasPublicas();
        }
        //Mostrar todos los Retos que son Publicos
        //URL Ejemplo: https://localhost:44317/GetRetosPublicos
        [HttpGet]
        [Route("GetRetosPublicos")]
        public IEnumerable<RetosPublicos> GetRetosPublicos()
        {
            return RetPublicosRepositorios.GetRetosPublicos();
        }
        //Ver los Retos que estarían disponibles según el Grupo en que este Asociado
        //URL Ejemplo: https://localhost:44317/GetRetosGrupos/adri45s
        [HttpGet]
        [Route("GetRetosGrupos/{deportista}")]
        public IEnumerable<RetosSegunGrupo> GetRetosGrupos(string deportista)
        {
            return RetosGruposRepositorio.GetRetosGrupos(deportista);
        }
        //Ver las Carreras que estarían disponibles según el Grupo en que este Asociado
        //URL Ejemplo: https://localhost:44317/GetCarrerasSegunGrupo/adri45s
        [HttpGet]
        [Route("GetCarrerasSegunGrupo/{deportista}")]
        public IEnumerable<CarrerasSegunGrupo> GetCarrerasSegunGrupo(string deportista)
        {
            return CarGruposRepositorio.GetCarrerasSegunGrupo(deportista);
        }
        //Ver el Resultado de una Carrera en la que estaba Inscrito
        //URL Ejemplo: https://localhost:44317/GetResultadoCarrera/Clasica%20Palmarin
        [HttpGet("{carrera}")]
        [Route("GetResultadoCarrera/{carrera}")]
        public IEnumerable<ResultadoCarrera> GetResultadoCarrera(string carrera)
        {
            return ResultCarreraRepositorio.GetResultadoCarrera(carrera);
        }
        //Ver todos los participante que hay Inscritos para una Carrera: Reporte
        //URL Ejemplo: https://localhost:44317/GetParticipantesCarrera/Clasica%20Palmarin
        [HttpGet("{carrera}")]
        [Route("GetParticipantesCarrera/{carrera}")]
        public IEnumerable<ParticipantesCarrera> GetParticipantesCarrera(string carrera)
        {
            return PartiCarreraRepositorio.GetParticipantesCarrera(carrera);
        }
        //Ver las posiciones de una Carrera: Reporte
        //URL Ejemplo:https://localhost:44317/GetPosicionesCarrera/Clasica%20Palmarin
        //No se Agrupan 
        [HttpGet("{carrera}")]
        [Route("GetPosicionesCarrera/{carrera}")]
        public IEnumerable<PosicionesCarrera> GetPosicionesCarrera(string carrera)
        {
            return PosiCarreraRepositorio.GetPosicionesCarrera(carrera);
        }
    }
}
