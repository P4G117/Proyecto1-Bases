using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Inscripcion
    {
        public int idinscripcion { get; set; }
        public int idcarrera { get; set; }
        public string usuariodep { get; set; }
        public string comprobante { get; set; }
        public string categoria { get; set; }

        public virtual Carrera IdCarreraNavigation { get; set; }
        public virtual Deportista UsuarioDepNavigation { get; set; }
    }
}
