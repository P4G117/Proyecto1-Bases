using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Deportista
    {
        
        public Deportista()
        {
            Actividad = new HashSet<Actividad>();
            AmigoAmigo1Navigation = new HashSet<Amigo>();
            AmigoDeportistaNavigation = new HashSet<Amigo>();
            DeportistaGrupo = new HashSet<DeportistaGrupo>();
            DeportistaReto = new HashSet<DeportistaReto>();
            Inscripcion = new HashSet<Inscripcion>();
        }
        
        public string UsuarioDep { get; set; }
        public string PrimerNombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public DateTime Fecnac { get; set; }
        public string Nacionalidad { get; set; }
        public string Foto { get; set; }
        public string Clave { get; set; }

        
        public virtual ICollection<Actividad> Actividad { get; set; }
        public virtual ICollection<Amigo> AmigoAmigo1Navigation { get; set; }
        public virtual ICollection<Amigo> AmigoDeportistaNavigation { get; set; }
        public virtual ICollection<DeportistaGrupo> DeportistaGrupo { get; set; }
        public virtual ICollection<DeportistaReto> DeportistaReto { get; set; }
        public virtual ICollection<Inscripcion> Inscripcion { get; set; }
        
    }
}
