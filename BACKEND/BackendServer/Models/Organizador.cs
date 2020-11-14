using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Organizador
    {
        public Organizador()
        {
            Carrera = new HashSet<Carrera>();
            Grupo = new HashSet<Grupo>();
            Reto = new HashSet<Reto>();
        }

        public string UsuarioOrg { get; set; }
        public string PrimerNombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime Fecnac { get; set; }
        public string Nacionalidad { get; set; }
        public string Foto { get; set; }
        public string Clave { get; set; }

        public virtual ICollection<Carrera> Carrera { get; set; }
        public virtual ICollection<Grupo> Grupo { get; set; }
        public virtual ICollection<Reto> Reto { get; set; }
    }
}
