using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class GrupoCarrera
    {
        public int idgrupo { get; set; }
        public int idcarrera { get; set; }

        public virtual Carrera IdCarreraNavigation { get; set; }
        public virtual Grupo IdGrupoNavigation { get; set; }
    }
}
