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
    public class DeportistaGrupoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DeportistaGrupoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/DeportistaGrupo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeportistaGrupo>>> GetDeportistaGrupo()
        {
            return await _context.DeportistaGrupo.ToListAsync();
        }

        // GET: api/DeportistaGrupo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DeportistaGrupo>> GetDeportistaGrupo(string id)
        {
            var deportistaGrupo = await _context.DeportistaGrupo.FindAsync(id);

            if (deportistaGrupo == null)
            {
                return NotFound();
            }

            return deportistaGrupo;
        }

        // PUT: api/DeportistaGrupo/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeportistaGrupo(string id, DeportistaGrupo deportistaGrupo)
        {
            if (id != deportistaGrupo.usuariodep)
            {
                return BadRequest();
            }

            _context.Entry(deportistaGrupo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeportistaGrupoExists(id))
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

        // POST: api/DeportistaGrupo
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DeportistaGrupo>> PostDeportistaGrupo(DeportistaGrupo deportistaGrupo)
        {
            _context.DeportistaGrupo.Add(deportistaGrupo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DeportistaGrupoExists(deportistaGrupo.usuariodep))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDeportistaGrupo", new { id = deportistaGrupo.usuariodep }, deportistaGrupo);
        }

        // DELETE: api/DeportistaGrupo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeportistaGrupo>> DeleteDeportistaGrupo(string id)
        {
            var deportistaGrupo = await _context.DeportistaGrupo.FindAsync(id);
            if (deportistaGrupo == null)
            {
                return NotFound();
            }

            _context.DeportistaGrupo.Remove(deportistaGrupo);
            await _context.SaveChangesAsync();

            return deportistaGrupo;
        }

        private bool DeportistaGrupoExists(string id)
        {
            return _context.DeportistaGrupo.Any(e => e.usuariodep == id);
        }
    }
}
