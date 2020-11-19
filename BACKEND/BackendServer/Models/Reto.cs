using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Reto
    {

        public int IdReto { get; set; }
        public string Nombre { get; set; }
        public DateTime Periodo { get; set; }
        public bool Privacidad { get; set; }
        public string TipoReto { get; set; }
        public string TipoActividad { get; set; }
        public string IdOrganizador { get; set; }

        /*
        public virtual Organizador IdOrganizadorNavigation { get; set; }
        public virtual ICollection<DeportistaReto> DeportistaReto { get; set; }
        public virtual ICollection<GrupoReto> GrupoReto { get; set; }
        public virtual ICollection<PatrocinadorReto> PatrocinadorReto { get; set; }
        */
    }
}
