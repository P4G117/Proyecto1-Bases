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
    public class CategoriaCarreraController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriaCarreraController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/CategoriaCarrera
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoriaCarrera>>> GetCategoriaCarrera()
        {
            return await _context.CategoriaCarrera.ToListAsync();
        }

        // GET: api/CategoriaCarrera/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoriaCarrera>> GetCategoriaCarrera(int id)
        {
            var categoriaCarrera = await _context.CategoriaCarrera.FindAsync(id);

            if (categoriaCarrera == null)
            {
                return NotFound();
            }

            return categoriaCarrera;
        }

        // PUT: api/CategoriaCarrera/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategoriaCarrera(int id, CategoriaCarrera categoriaCarrera)
        {
            if (id != categoriaCarrera.IdCarrera)
            {
                return BadRequest();
            }

            _context.Entry(categoriaCarrera).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoriaCarreraExists(id))
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

        // POST: api/CategoriaCarrera
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<CategoriaCarrera>> PostCategoriaCarrera(CategoriaCarrera categoriaCarrera)
        {
            _context.CategoriaCarrera.Add(categoriaCarrera);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CategoriaCarreraExists(categoriaCarrera.IdCarrera))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCategoriaCarrera", new { id = categoriaCarrera.IdCarrera }, categoriaCarrera);
        }

        // DELETE: api/CategoriaCarrera/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<CategoriaCarrera>> DeleteCategoriaCarrera(int id)
        {
            var categoriaCarrera = await _context.CategoriaCarrera.FindAsync(id);
            if (categoriaCarrera == null)
            {
                return NotFound();
            }

            _context.CategoriaCarrera.Remove(categoriaCarrera);
            await _context.SaveChangesAsync();

            return categoriaCarrera;
        }

        private bool CategoriaCarreraExists(int id)
        {
            return _context.CategoriaCarrera.Any(e => e.IdCarrera == id);
        }
    }
}
