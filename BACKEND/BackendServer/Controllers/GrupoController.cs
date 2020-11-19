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
    public class GrupoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GrupoController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Grupo
        [HttpGet]
        public IEnumerable<Grupo> GetAllGrupo()
        {
            return GrupoRepositorio.GetGrupos();
        }

        // GET: api/Grupo/5
        [HttpGet("{id}")]
        public List<Grupo> Getgrupo(int id)
        {
            return GrupoRepositorio.GetGrupo(id);
        }

        // PUT: api/Grupo/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public bool PutGrupo(int id, Grupo grupo)
        {
            return GrupoRepositorio.UpdateGrupo(id,grupo);
        }

        // POST: api/Grupo
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public bool PostGrupo(Grupo grupo)
        {
            return GrupoRepositorio.PostGrupo(grupo);
        }

        // DELETE: api/Grupo/5
        [HttpDelete("{id}")]
        public bool DeleteGrupo(int id)
        {
            return GrupoRepositorio.DeleteDeportista(id);
        }

        private bool GrupoExists(int id)
        {
            return _context.Grupo.Any(e => e.idgrupo == id);
        }
    }
}
