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
        [HttpGet]
        [Route("GetActiAmigos/{deportista}")]
        public IEnumerable<ActividadesAmigos> Get(string deportista)
        {
            return ActividadesAmigosRepositorio.GetActividadesAmigos(deportista);
        }
        //Para ver a todos los Deportistas que no sean Amigos 
        [HttpGet]
        [Route("GetPosAmigos/{deportista}")]
        public IEnumerable<PosiblesAmigos> Get1(string deportista)
        {
            return PosAmigosReporsitorio.GetPosiblesAmigos(deportista);
        }
        //Mostrar todas las carreras que son Publicas 
        [HttpGet]
        [Route("GetCarrerasPublicas")]
        public IEnumerable<CarrerasPublicas> GetCarrerasPublicas()
        {
            return CarPublicasRepositorio.GetCarrerasPublicas();
        }
        //Mostrar todos los Retos que son Publicos
        [HttpGet]
        [Route("GetRetosPublicos")]
        public IEnumerable<RetosPublicos> GetRetosPublicos()
        {
            return RetPublicosRepositorios.GetRetosPublicos();
        }
        //Ver los Retos que estarían disponibles según el Grupo en que este Asociado
        [HttpGet]
        [Route("GetRetosGrupos/{deportista}")]
        public IEnumerable<RetosSegunGrupo> GetRetosGrupos(string deportista)
        {
            return RetosGruposRepositorio.GetRetosGrupos(deportista);
        }
        //Ver las Carreras que estarían disponibles según el Grupo en que este Asociado
        [HttpGet]
        [Route("GetCarrerasSegunGrupo/{deportista}")]
        public IEnumerable<CarrerasSegunGrupo> GetCarrerasSegunGrupo(string deportista)
        {
            return CarGruposRepositorio.GetCarrerasSegunGrupo(deportista);
        }
    }
}
