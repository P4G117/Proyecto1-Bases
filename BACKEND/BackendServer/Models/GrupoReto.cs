using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class GrupoReto
    {
        public int IdGrupo { get; set; }
        public int IdReto { get; set; }

        public virtual Grupo IdGrupoNavigation { get; set; }
        public virtual Reto IdRetoNavigation { get; set; }
    }
}
