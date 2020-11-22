using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Inscripcion
    {
        public int ID_Inscripcion { get; set; }
        public int ID_Carrera { get; set; }
        public string Usuario_Dep { get; set; }
        public string Comprobante { get; set; }
        public string Categoria { get; set; }

    }
}
