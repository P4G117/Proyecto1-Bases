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
    public class DeportistaRetoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DeportistaRetoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DeportistaReto
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeportistaReto>>> GetDeportistaReto()
        {
            return await _context.DeportistaReto.ToListAsync();
        }

        // GET: api/DeportistaReto/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeportistaReto>> GetDeportistaReto(string id)
        {
            var deportistaReto = await _context.DeportistaReto.FindAsync(id);

            if (deportistaReto == null)
            {
                return NotFound();
            }

            return deportistaReto;
        }

        // PUT: api/DeportistaReto/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeportistaReto(string id, DeportistaReto deportistaReto)
        {
            if (id != deportistaReto.usuariodep)
            {
                return BadRequest();
            }

            _context.Entry(deportistaReto).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeportistaRetoExists(id))
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

        // POST: api/DeportistaReto
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DeportistaReto>> PostDeportistaReto(DeportistaReto deportistaReto)
        {
            _context.DeportistaReto.Add(deportistaReto);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DeportistaRetoExists(deportistaReto.usuariodep))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDeportistaReto", new { id = deportistaReto.usuariodep }, deportistaReto);
        }

        // DELETE: api/DeportistaReto/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeportistaReto>> DeleteDeportistaReto(string id)
        {
            var deportistaReto = await _context.DeportistaReto.FindAsync(id);
            if (deportistaReto == null)
            {
                return NotFound();
            }

            _context.DeportistaReto.Remove(deportistaReto);
            await _context.SaveChangesAsync();

            return deportistaReto;
        }

        private bool DeportistaRetoExists(string id)
        {
            return _context.DeportistaReto.Any(e => e.usuariodep == id);
        }
    }
}
