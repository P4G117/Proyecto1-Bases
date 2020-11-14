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
    public class GrupoRetoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GrupoRetoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/GrupoReto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GrupoReto>>> GetGrupoReto()
        {
            return await _context.GrupoReto.ToListAsync();
        }

        // GET: api/GrupoReto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GrupoReto>> GetGrupoReto(int id)
        {
            var grupoReto = await _context.GrupoReto.FindAsync(id);

            if (grupoReto == null)
            {
                return NotFound();
            }

            return grupoReto;
        }

        // PUT: api/GrupoReto/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrupoReto(int id, GrupoReto grupoReto)
        {
            if (id != grupoReto.IdGrupo)
            {
                return BadRequest();
            }

            _context.Entry(grupoReto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GrupoRetoExists(id))
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

        // POST: api/GrupoReto
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<GrupoReto>> PostGrupoReto(GrupoReto grupoReto)
        {
            _context.GrupoReto.Add(grupoReto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GrupoRetoExists(grupoReto.IdGrupo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGrupoReto", new { id = grupoReto.IdGrupo }, grupoReto);
        }

        // DELETE: api/GrupoReto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GrupoReto>> DeleteGrupoReto(int id)
        {
            var grupoReto = await _context.GrupoReto.FindAsync(id);
            if (grupoReto == null)
            {
                return NotFound();
            }

            _context.GrupoReto.Remove(grupoReto);
            await _context.SaveChangesAsync();

            return grupoReto;
        }

        private bool GrupoRetoExists(int id)
        {
            return _context.GrupoReto.Any(e => e.IdGrupo == id);
        }
    }
}
