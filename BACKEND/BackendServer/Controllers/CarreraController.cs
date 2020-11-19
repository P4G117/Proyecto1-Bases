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
    public class CarreraController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarreraController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Carrera
        [HttpGet]
        public IEnumerable<Carrera> GetCarreras()
        {
            return CarreraRepositorio.GetAllCarreras();
        }

        // GET: api/Carrera/5
        [HttpGet("{carrera}")]
        public IEnumerable<Carrera> GetCarrera(int carrera)
        {
            return CarreraRepositorio.GetCarrera(carrera);
        }

        // PUT: api/Carrera/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{nombreCarrera}")]
        public bool PutCarrera(int nombreCarrera, Carrera carrera)
        {
            return CarreraRepositorio.UpdateCarrera(nombreCarrera,carrera);
        }

        // POST: api/Carrera
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public bool PostCarrera(Carrera carrera)
        {
            return CarreraRepositorio.PostCarrera(carrera); 
        }

        // DELETE: api/Carrera/5
        [HttpDelete("{id}")]
        public bool DeleteCarrera(int id)
        { 
            return CarreraRepositorio.DeleteCarrera(id);
        }

        private bool CarreraExists(int id)
        {
            return _context.Carrera.Any(e => e.idcarrera == id);
        }
    }
}
