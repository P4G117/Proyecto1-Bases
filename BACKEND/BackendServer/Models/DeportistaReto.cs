using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class DeportistaReto
    {
        public string UsuarioDep { get; set; }
        public int IdReto { get; set; }

        public virtual Reto IdRetoNavigation { get; set; }
        public virtual Deportista UsuarioDepNavigation { get; set; }
    }
}
