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
    public class PatrocinadorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatrocinadorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Patrocinador
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Patrocinador>>> GetPatrocinador()
        {
            return await _context.Patrocinador.ToListAsync();
        }

        // GET: api/Patrocinador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Patrocinador>> GetPatrocinador(int id)
        {
            var patrocinador = await _context.Patrocinador.FindAsync(id);

            if (patrocinador == null)
            {
                return NotFound();
            }

            return patrocinador;
        }

        // PUT: api/Patrocinador/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatrocinador(int id, Patrocinador patrocinador)
        {
            if (id != patrocinador.IdPatrocinador)
            {
                return BadRequest();
            }

            _context.Entry(patrocinador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatrocinadorExists(id))
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

        // POST: api/Patrocinador
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Patrocinador>> PostPatrocinador(Patrocinador patrocinador)
        {
            _context.Patrocinador.Add(patrocinador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPatrocinador", new { id = patrocinador.IdPatrocinador }, patrocinador);
        }

        // DELETE: api/Patrocinador/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Patrocinador>> DeletePatrocinador(int id)
        {
            var patrocinador = await _context.Patrocinador.FindAsync(id);
            if (patrocinador == null)
            {
                return NotFound();
            }

            _context.Patrocinador.Remove(patrocinador);
            await _context.SaveChangesAsync();

            return patrocinador;
        }

        private bool PatrocinadorExists(int id)
        {
            return _context.Patrocinador.Any(e => e.IdPatrocinador == id);
        }
    }
}
