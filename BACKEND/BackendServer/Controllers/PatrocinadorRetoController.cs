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
    public class PatrocinadorRetoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatrocinadorRetoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PatrocinadorReto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatrocinadorReto>>> GetPatrocinadorReto()
        {
            return await _context.PatrocinadorReto.ToListAsync();
        }

        // GET: api/PatrocinadorReto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatrocinadorReto>> GetPatrocinadorReto(int id)
        {
            var patrocinadorReto = await _context.PatrocinadorReto.FindAsync(id);

            if (patrocinadorReto == null)
            {
                return NotFound();
            }

            return patrocinadorReto;
        }

        // PUT: api/PatrocinadorReto/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatrocinadorReto(int id, PatrocinadorReto patrocinadorReto)
        {
            if (id != patrocinadorReto.IdPatrocinador)
            {
                return BadRequest();
            }

            _context.Entry(patrocinadorReto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatrocinadorRetoExists(id))
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

        // POST: api/PatrocinadorReto
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PatrocinadorReto>> PostPatrocinadorReto(PatrocinadorReto patrocinadorReto)
        {
            _context.PatrocinadorReto.Add(patrocinadorReto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PatrocinadorRetoExists(patrocinadorReto.IdPatrocinador))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPatrocinadorReto", new { id = patrocinadorReto.IdPatrocinador }, patrocinadorReto);
        }

        // DELETE: api/PatrocinadorReto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PatrocinadorReto>> DeletePatrocinadorReto(int id)
        {
            var patrocinadorReto = await _context.PatrocinadorReto.FindAsync(id);
            if (patrocinadorReto == null)
            {
                return NotFound();
            }

            _context.PatrocinadorReto.Remove(patrocinadorReto);
            await _context.SaveChangesAsync();

            return patrocinadorReto;
        }

        private bool PatrocinadorRetoExists(int id)
        {
            return _context.PatrocinadorReto.Any(e => e.IdPatrocinador == id);
        }
    }
}
