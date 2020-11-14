using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class DeportistaGrupo
    {
        public string UsuarioDep { get; set; }
        public int IdGrupo { get; set; }

        public virtual Grupo IdGrupoNavigation { get; set; }
        public virtual Deportista UsuarioDepNavigation { get; set; }
    }
}
