using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendServer.Models
{
    public class CarrerasPublicas
    {
        public int idcarrera { get; set; }
        public string nombre { get; set; }
        public string fecha { get; set; }
        public string recorrido { get; set; }
        public long cuenta { get; set; }
        public int costo { get; set; }
        public string tipoActividad { get; set; }
    }
}
