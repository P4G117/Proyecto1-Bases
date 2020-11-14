using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Inscripcion
    {
        public int IdInscripcion { get; set; }
        public int IdCarrera { get; set; }
        public string UsuarioDep { get; set; }
        public string Comprobante { get; set; }
        public string Categoria { get; set; }

        public virtual Carrera IdCarreraNavigation { get; set; }
        public virtual Deportista UsuarioDepNavigation { get; set; }
    }
}
