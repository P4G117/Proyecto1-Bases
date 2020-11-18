using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Amigo
    {
        public string deportista { get; set; }
        public string amigo1 { get; set; }

        //public virtual Deportista Amigo1Navigation { get; set; }
        //public virtual Deportista DeportistaNavigation { get; set; }
    }
}
