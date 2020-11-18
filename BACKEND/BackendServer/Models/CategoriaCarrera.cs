using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class CategoriaCarrera
    {
        public int idcategoria { get; set; }
        public int idcarrera { get; set; }

        public virtual Carrera IdCarreraNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
