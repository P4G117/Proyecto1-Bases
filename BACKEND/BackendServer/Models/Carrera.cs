using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Carrera
    {
        /*
        public Carrera()
        {
            CategoriaCarrera = new HashSet<CategoriaCarrera>();
            GrupoCarrera = new HashSet<GrupoCarrera>();
            Inscripcion = new HashSet<Inscripcion>();
            PatrocinadorCarrera = new HashSet<PatrocinadorCarrera>();
        }
        */
        public int IdCarrera { get; set; }
        public string IdOrganizador { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Recorrido { get; set; }
        public decimal Cuenta { get; set; }
        public decimal Costo { get; set; }
        public bool Privacidad { get; set; }
        public string TipoActividad { get; set; }
        /*
        public virtual Organizador IdOrganizadorNavigation { get; set; }
        public virtual ICollection<CategoriaCarrera> CategoriaCarrera { get; set; }
        public virtual ICollection<GrupoCarrera> GrupoCarrera { get; set; }
        public virtual ICollection<Inscripcion> Inscripcion { get; set; }
        public virtual ICollection<PatrocinadorCarrera> PatrocinadorCarrera { get; set; }
        */
    }
}
