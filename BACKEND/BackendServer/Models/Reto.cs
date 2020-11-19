using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Reto
    {

        public int IdReto { get; set; }
        public string Nombre { get; set; }
        public string Periodo { get; set; }
        public bool Privacidad { get; set; }
        public string TipoReto { get; set; }
        public string TipoActividad { get; set; }
        public string IdOrganizador { get; set; }

    }
}
