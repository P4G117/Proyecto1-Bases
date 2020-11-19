using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Carrera
    {
        public int idcarrera { get; set; }
        public string idorganizador { get; set; }
        public string nombre { get; set; }
        public string fecha { get; set; }
        public string recorrido { get; set; }
        public Int64 cuenta { get; set; }
        public Int64 costo { get; set; }
        public bool privacidad { get; set; }
        public string tipoActividad { get; set; }
   }
}
