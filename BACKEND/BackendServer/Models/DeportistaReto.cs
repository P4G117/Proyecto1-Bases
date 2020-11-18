using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class DeportistaReto
    {
        public string usuariodep { get; set; }
        public int idreto { get; set; }
        public virtual Reto IdRetoNavigation { get; set; }
        public virtual Deportista UsuarioDepNavigation { get; set; }
    }
}
