using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendServer.Models
{
    public class CarrerasSegunGrupo
    {
        public string nombregrupo { get; set; }
        public int idcarrera { get; set; }
        public string nombrecarrera { get; set; }
        public string fecha { get; set; }
        public string recorrido { get; set; }
        public long cuenta { get; set; }
        public int costo { get; set; }
        public string tipoActividad { get; set; }
    }
}
