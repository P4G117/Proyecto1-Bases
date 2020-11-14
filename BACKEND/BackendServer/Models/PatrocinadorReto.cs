using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class PatrocinadorReto
    {
        public int IdPatrocinador { get; set; }
        public int IdReto { get; set; }

        public virtual Patrocinador IdPatrocinadorNavigation { get; set; }
        public virtual Reto IdRetoNavigation { get; set; }
    }
}
