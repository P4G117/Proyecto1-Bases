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
    public class DeportistaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DeportistaController(AppDbContext context)
        {
            _context = context;
        }

       // GET: api/Deportista
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deportista>>> GetDeportista()
        {
            return await _context.Deportista.ToListAsync();
        }


        [HttpGet("sol")]
        public IActionResult GetDeportistaS()
        {

            Class clase = new Class
            {
                usuariodep = "gula",
                primernombre = "viviana",
                apellido1 = "lola",
                apellido2 = 4,
                fecnac = "2020-12-05",
                nacionalidad = "francesa",
                foto = "URL 2",
                clave = "lol"
            };

            return Ok(clase);
        }

        // GET: api/Deportista/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Deportista>> GetDeportista(string id)
        {
            var deportista = await _context.Deportista.FindAsync(id);

            if (deportista == null)
            {
                return NotFound();
            }

            return deportista;
        }

        // PUT: api/Deportista/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeportista(string id, Deportista deportista)
        {
            if (id != deportista.UsuarioDep)
            {
                return BadRequest();
            }

            _context.Entry(deportista).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeportistaExists(id))
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

        // POST: api/Deportista
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Deportista>> PostDeportista(Deportista deportista)
        {
            _context.Deportista.Add(deportista);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DeportistaExists(deportista.UsuarioDep))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDeportista", new { id = deportista.UsuarioDep }, deportista);
        }

        // DELETE: api/Deportista/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Deportista>> DeleteDeportista(string id)
        {
            var deportista = await _context.Deportista.FindAsync(id);
            if (deportista == null)
            {
                return NotFound();
            }

            _context.Deportista.Remove(deportista);
            await _context.SaveChangesAsync();

            return deportista;
        }

        private bool DeportistaExists(string id)
        {
            return _context.Deportista.Any(e => e.UsuarioDep == id);
        }
    }
}
