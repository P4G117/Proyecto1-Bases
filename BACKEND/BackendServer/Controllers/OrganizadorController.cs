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
    public class OrganizadorController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrganizadorController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Organizador
        [HttpGet]
        public IEnumerable<Organizador> GetOrganizador()
        {
            return OrganizadorRepositorio.GetAllOrganizadores();
        }

        // GET: api/Organizador/5
        [HttpGet("{id}")]
        public IEnumerable<Organizador> GetOrganizador(string id)
        {
            return OrganizadorRepositorio.GetOrganizador(id);
        }

        // PUT: api/Organizador/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public bool PutOrganizador(string id, Organizador organizador)
        {
            return OrganizadorRepositorio.UpdateOrganizador(id,organizador);
        }

        // POST: api/Organizador
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public bool PostOrganizador(Organizador organizador)
        {
            return OrganizadorRepositorio.PostOrganizador(organizador);
        }

        // DELETE: api/Organizador/5
        [HttpDelete("{id}")]
        public bool DeleteOrganizador(string id)
        {
            return OrganizadorRepositorio.DeleteOrganizador(id);
        }

        private bool OrganizadorExists(string id)
        {
            return _context.Organizador.Any(e => e.usuarioorg == id);
        }
    }
}
