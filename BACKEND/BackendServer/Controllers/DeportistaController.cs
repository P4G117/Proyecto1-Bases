using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BackendServer.Models;
using BackendServer.Repositorios;

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
        public IEnumerable<Deportista> GetAllDeportista()
        {
            return DeportistaRepositorio.GetAllDeportistas();
            //return await _context.Deportista.ToListAsync();
        }

        // GET: api/Deportista/5
        [HttpGet("{id}")]
        public IEnumerable<Deportista> GetDeportista(string id)
        {
            /*
            var deportista = await _context.Deportista.FindAsync(id);

            if (deportista == null)
            {
                return NotFound();
            }
            */

            return DeportistaRepositorio.GetDeportistas(id);//deportista;
        }

        // PUT: api/Deportista/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public bool PutDeportista(Deportista deportista)
        {
            /*
            if (id != deportista.usuariodep)
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
            */

            return DeportistaRepositorio.UpdateDeportista(deportista);//NoContent();
        }

        // POST: api/Deportista
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public bool PostDeportista(Deportista deportista)
        {
            
            return DeportistaRepositorio.PostDeportista(deportista); 
        }

        // DELETE: api/Deportista/5
        [HttpDelete("{id}")]
        public bool DeleteDeportista(string id)
        {
            
            return DeportistaRepositorio.DeleteDeportista(id);
        }

        private bool DeportistaExists(string id)
        {
            return _context.Deportista.Any(e => e.usuariodep == id);
        }
    }
}
