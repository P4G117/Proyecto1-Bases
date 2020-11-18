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
<<<<<<< Updated upstream
        public int IdCarrera { get; set; }
        public string IdOrganizador { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Recorrido { get; set; }
        public decimal Cuenta { get; set; }
        public decimal Costo { get; set; }
        public bool Privacidad { get; set; }
        public string TipoActividad { get; set; }
=======
        public int idcarrera { get; set; }
        public string idorganizador { get; set; }
        public string nombre { get; set; }
        public string fecha { get; set; }
        public string recorrido { get; set; }
        public decimal cuenta { get; set; }
        public decimal costo { get; set; }
        public bool privacidad { get; set; }
        public string tipoActividad { get; set; }
>>>>>>> Stashed changes
        /*
        public virtual Organizador IdOrganizadorNavigation { get; set; }
        public virtual ICollection<CategoriaCarrera> CategoriaCarrera { get; set; }
        public virtual ICollection<GrupoCarrera> GrupoCarrera { get; set; }
        public virtual ICollection<Inscripcion> Inscripcion { get; set; }
        public virtual ICollection<PatrocinadorCarrera> PatrocinadorCarrera { get; set; }
        */
<<<<<<< Updated upstream
=======
        
>>>>>>> Stashed changes
    }
}
