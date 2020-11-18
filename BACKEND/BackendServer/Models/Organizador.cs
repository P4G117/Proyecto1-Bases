using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Organizador
    {
        /*
        public Organizador()
        {
            Carrera = new HashSet<Carrera>();
            Grupo = new HashSet<Grupo>();
            Reto = new HashSet<Reto>();
        }
        */
        public string usuarioorg { get; set; }
        public string primernombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string fecnac { get; set; }
        public string nacionalidad { get; set; }
        public string foto { get; set; }
        public string clave { get; set; }

        /*
        public virtual ICollection<Carrera> Carrera { get; set; }
        public virtual ICollection<Grupo> Grupo { get; set; }
        public virtual ICollection<Reto> Reto { get; set; }
        */
    }
}
