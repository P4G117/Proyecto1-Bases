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
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ActividadController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Actividad
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actividad>>> GetActividad()
        {
            return await _context.Actividad.ToListAsync();
        }

        // GET: api/Actividad/5
        [HttpGet("{deportista}")]
        public IEnumerable<Actividad> GetCarrera(string deportista)
        {
            return ActividadesRepositorio.GetAllActividadesDep(deportista);
        }

        // PUT: api/Actividad/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{idactividad}")]
        public bool PutActividad(int idactividad, Actividad actividad)
        {
            return ActividadesRepositorio.UpdateActividad(idactividad, actividad);
        }

        // POST: api/Actividad
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public bool PostActividad(Actividad actividad)
        {
            return ActividadesRepositorio.PostActividad(actividad);
        }

        // DELETE: api/Actividad/5
        [HttpDelete("{id}")]
        public bool DeleteActividad(int id)
        {
            return ActividadesRepositorio.DeleteActividad(id);
        }

        private bool ActividadExists(int id)
        {
            return _context.Actividad.Any(e => e.IdActividad == id);
        }
    }
}
