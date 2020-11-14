using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            CategoriaCarrera = new HashSet<CategoriaCarrera>();
        }

        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<CategoriaCarrera> CategoriaCarrera { get; set; }
    }
}
