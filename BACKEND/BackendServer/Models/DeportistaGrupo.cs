using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class DeportistaGrupo
    {
        public string usuariodep { get; set; }
        public int idgrupo { get; set; }

        public virtual Grupo IdGrupoNavigation { get; set; }
        public virtual Deportista UsuarioDepNavigation { get; set; }
    }
}
