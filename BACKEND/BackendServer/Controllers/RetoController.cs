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
    public class RetoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RetoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Reto
        [HttpGet]
        public IEnumerable<Reto> GetAllReto()
        {
            return RetoRepositorio.GetAllRetos();
        }

        // GET: api/Reto/5
        [HttpGet("{id}")]
        public IEnumerable<Reto> GetReto(int id)
        {
            return RetoRepositorio.GetReto(id);
        }

        // PUT: api/Reto/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public bool PutReto(int id, Reto reto)
        {
            return RetoRepositorio.UpdateReto(id, reto);
        }

        // POST: api/Reto
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public bool PostReto(Reto reto)
        {
            return RetoRepositorio.PostReto(reto);
        }

        // DELETE: api/Reto/5
        [HttpDelete("{id}")]
        public bool DeleteReto(int id)
        {
            return RetoRepositorio.DeleteReto(id);
        }

        private bool RetoExists(int id)
        {
            return _context.Reto.Any(e => e.IdReto == id);
        }
    }
}
