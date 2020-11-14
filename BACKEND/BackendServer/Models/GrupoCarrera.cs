using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class GrupoCarrera
    {
        public int IdGrupo { get; set; }
        public int IdCarrera { get; set; }

        public virtual Carrera IdCarreraNavigation { get; set; }
        public virtual Grupo IdGrupoNavigation { get; set; }
    }
}
