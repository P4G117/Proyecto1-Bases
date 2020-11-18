using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class PatrocinadorReto
    {
        public int idpatrocinador { get; set; }
        public int idreto { get; set; }

        public virtual Patrocinador IdPatrocinadorNavigation { get; set; }
        public virtual Reto IdRetoNavigation { get; set; }
    }
}
