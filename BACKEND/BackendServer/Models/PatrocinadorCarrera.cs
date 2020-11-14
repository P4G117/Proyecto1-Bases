using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class PatrocinadorCarrera
    {
        public int IdPatrocinador { get; set; }
        public int IdCarrera { get; set; }

        public virtual Carrera IdCarreraNavigation { get; set; }
        public virtual Patrocinador IdPatrocinadorNavigation { get; set; }
    }
}
