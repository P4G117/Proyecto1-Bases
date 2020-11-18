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
    public class OrganizadorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrganizadorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Organizador
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organizador>>> GetOrganizador()
        {
            return await _context.Organizador.ToListAsync();
        }

        // GET: api/Organizador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Organizador>> GetOrganizador(string id)
        {
            var organizador = await _context.Organizador.FindAsync(id);

            if (organizador == null)
            {
                return NotFound();
            }

            return organizador;
        }

        // PUT: api/Organizador/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrganizador(string id, Organizador organizador)
        {
            if (id != organizador.usuarioorg)
            {
                return BadRequest();
            }

            _context.Entry(organizador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrganizadorExists(id))
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

        // POST: api/Organizador
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Organizador>> PostOrganizador(Organizador organizador)
        {
            _context.Organizador.Add(organizador);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (OrganizadorExists(organizador.usuarioorg))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetOrganizador", new { id = organizador.usuarioorg }, organizador);
        }

        // DELETE: api/Organizador/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Organizador>> DeleteOrganizador(string id)
        {
            var organizador = await _context.Organizador.FindAsync(id);
            if (organizador == null)
            {
                return NotFound();
            }

            _context.Organizador.Remove(organizador);
            await _context.SaveChangesAsync();

            return organizador;
        }

        private bool OrganizadorExists(string id)
        {
            return _context.Organizador.Any(e => e.usuarioorg == id);
        }
    }
}
