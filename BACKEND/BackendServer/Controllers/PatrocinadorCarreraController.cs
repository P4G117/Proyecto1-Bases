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
    public class PatrocinadorCarreraController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PatrocinadorCarreraController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/PatrocinadorCarrera
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PatrocinadorCarrera>>> GetPatrocinadorCarrera()
        {
            return await _context.PatrocinadorCarrera.ToListAsync();
        }

        // GET: api/PatrocinadorCarrera/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PatrocinadorCarrera>> GetPatrocinadorCarrera(int id)
        {
            var patrocinadorCarrera = await _context.PatrocinadorCarrera.FindAsync(id);

            if (patrocinadorCarrera == null)
            {
                return NotFound();
            }

            return patrocinadorCarrera;
        }

        // PUT: api/PatrocinadorCarrera/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPatrocinadorCarrera(int id, PatrocinadorCarrera patrocinadorCarrera)
        {
            if (id != patrocinadorCarrera.idcarrera)
            {
                return BadRequest();
            }

            _context.Entry(patrocinadorCarrera).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PatrocinadorCarreraExists(id))
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

        // POST: api/PatrocinadorCarrera
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<PatrocinadorCarrera>> PostPatrocinadorCarrera(PatrocinadorCarrera patrocinadorCarrera)
        {
            _context.PatrocinadorCarrera.Add(patrocinadorCarrera);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (PatrocinadorCarreraExists(patrocinadorCarrera.idcarrera))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetPatrocinadorCarrera", new { id = patrocinadorCarrera.idcarrera }, patrocinadorCarrera);
        }

        // DELETE: api/PatrocinadorCarrera/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PatrocinadorCarrera>> DeletePatrocinadorCarrera(int id)
        {
            var patrocinadorCarrera = await _context.PatrocinadorCarrera.FindAsync(id);
            if (patrocinadorCarrera == null)
            {
                return NotFound();
            }

            _context.PatrocinadorCarrera.Remove(patrocinadorCarrera);
            await _context.SaveChangesAsync();

            return patrocinadorCarrera;
        }

        private bool PatrocinadorCarreraExists(int id)
        {
            return _context.PatrocinadorCarrera.Any(e => e.idcarrera == id);
        }
    }
}
