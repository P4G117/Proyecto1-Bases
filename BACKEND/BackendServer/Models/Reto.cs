using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Reto
    {
<<<<<<< Updated upstream
        
        /*public Reto()
=======
        /*
        public Reto()
>>>>>>> Stashed changes
        {
            DeportistaReto = new HashSet<DeportistaReto>();
            GrupoReto = new HashSet<GrupoReto>();
            PatrocinadorReto = new HashSet<PatrocinadorReto>();
        }
        */
        public int IdReto { get; set; }
        public string Nombre { get; set; }
        public DateTime Periodo { get; set; }
        public bool Privacidad { get; set; }
        public string TipoReto { get; set; }
        public string TipoActividad { get; set; }
        public string IdOrganizador { get; set; }
<<<<<<< Updated upstream
        
=======
>>>>>>> Stashed changes
        /*
        public virtual Organizador IdOrganizadorNavigation { get; set; }
        public virtual ICollection<DeportistaReto> DeportistaReto { get; set; }
        public virtual ICollection<GrupoReto> GrupoReto { get; set; }
        public virtual ICollection<PatrocinadorReto> PatrocinadorReto { get; set; }
        */
    }
}
