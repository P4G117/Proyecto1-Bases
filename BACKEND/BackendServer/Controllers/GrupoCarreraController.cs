using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendServer.Models;

namespace BackendServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrupoCarreraController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GrupoCarreraController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/GrupoCarrera
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrupoCarrera>>> GetGrupoCarrera()
        {
            return await _context.GrupoCarrera.ToListAsync();
        }

        // GET: api/GrupoCarrera/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GrupoCarrera>> GetGrupoCarrera(int id)
        {
            var grupoCarrera = await _context.GrupoCarrera.FindAsync(id);

            if (grupoCarrera == null)
            {
                return NotFound();
            }

            return grupoCarrera;
        }

        // PUT: api/GrupoCarrera/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrupoCarrera(int id, GrupoCarrera grupoCarrera)
        {
            if (id != grupoCarrera.idgrupo)
            {
                return BadRequest();
            }

            _context.Entry(grupoCarrera).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrupoCarreraExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/GrupoCarrera
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GrupoCarrera>> PostGrupoCarrera(GrupoCarrera grupoCarrera)
        {
            _context.GrupoCarrera.Add(grupoCarrera);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GrupoCarreraExists(grupoCarrera.idgrupo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGrupoCarrera", new { id = grupoCarrera.idgrupo }, grupoCarrera);
        }

        // DELETE: api/GrupoCarrera/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GrupoCarrera>> DeleteGrupoCarrera(int id)
        {
            var grupoCarrera = await _context.GrupoCarrera.FindAsync(id);
            if (grupoCarrera == null)
            {
                return NotFound();
            }

            _context.GrupoCarrera.Remove(grupoCarrera);
            await _context.SaveChangesAsync();

            return grupoCarrera;
        }

        private bool GrupoCarreraExists(int id)
        {
            return _context.GrupoCarrera.Any(e => e.idgrupo == id);
        }
    }
}
