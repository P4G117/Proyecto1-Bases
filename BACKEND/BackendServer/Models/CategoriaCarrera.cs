using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class CategoriaCarrera
    {
        public int IdCategoria { get; set; }
        public int IdCarrera { get; set; }

        public virtual Carrera IdCarreraNavigation { get; set; }
        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
