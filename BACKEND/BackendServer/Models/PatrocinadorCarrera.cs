using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class PatrocinadorCarrera
    {
        public int idpatrocinador { get; set; }
        public int idcarrera { get; set; }

        //public virtual Carrera idcarreraNavigation { get; set; }
        //public virtual Patrocinador idpatrocinadorNavigation { get; set; }
    }
}
