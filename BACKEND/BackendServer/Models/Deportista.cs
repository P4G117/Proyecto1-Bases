using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Deportista
    {
        /*
        public Deportista()
        {
            Actividad = new HashSet<Actividad>();
            AmigoAmigo1Navigation = new HashSet<Amigo>();
            AmigoDeportistaNavigation = new HashSet<Amigo>();
            DeportistaGrupo = new HashSet<DeportistaGrupo>();
            DeportistaReto = new HashSet<DeportistaReto>();
            Inscripcion = new HashSet<Inscripcion>();
        }
        */
        
        public string usuariodep { get; set; }
        public string primernombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public string fecnac { get; set; }
        public string nacionalidad { get; set; }
        public string foto { get; set; }
        public string clave { get; set; }

        /*
       
        public virtual ICollection<Actividad> Actividad { get; set; }
        public virtual ICollection<Amigo> AmigoAmigo1Navigation { get; set; }
        public virtual ICollection<Amigo> AmigoDeportistaNavigation { get; set; }
        public virtual ICollection<DeportistaGrupo> DeportistaGrupo { get; set; }
        public virtual ICollection<DeportistaReto> DeportistaReto { get; set; }
        public virtual ICollection<Inscripcion> Inscripcion { get; set; }
        */
    }
}
