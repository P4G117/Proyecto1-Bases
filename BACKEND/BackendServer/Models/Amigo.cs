using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Amigo
    {
        public string Deportista { get; set; }
        public string Amigo1 { get; set; }

        public virtual Deportista Amigo1Navigation { get; set; }
        public virtual Deportista DeportistaNavigation { get; set; }
    }
}
