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
    public class AmigoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AmigoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Amigo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amigo>>> GetAmigo()
        {
            return await _context.Amigo.ToListAsync();
        }

        // GET: api/Amigo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Amigo>> GetAmigo(string id)
        {
            var amigo = await _context.Amigo.FindAsync(id);

            if (amigo == null)
            {
                return NotFound();
            }

            return amigo;
        }

        // PUT: api/Amigo/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmigo(string id, Amigo amigo)
        {
            if (id != amigo.Deportista)
            {
                return BadRequest();
            }

            _context.Entry(amigo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AmigoExists(id))
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

        // POST: api/Amigo
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Amigo>> PostAmigo(Amigo amigo)
        {
            _context.Amigo.Add(amigo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AmigoExists(amigo.Deportista))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAmigo", new { id = amigo.Deportista }, amigo);
        }

        // DELETE: api/Amigo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Amigo>> DeleteAmigo(string id)
        {
            var amigo = await _context.Amigo.FindAsync(id);
            if (amigo == null)
            {
                return NotFound();
            }

            _context.Amigo.Remove(amigo);
            await _context.SaveChangesAsync();

            return amigo;
        }

        private bool AmigoExists(string id)
        {
            return _context.Amigo.Any(e => e.Deportista == id);
        }
    }
}
