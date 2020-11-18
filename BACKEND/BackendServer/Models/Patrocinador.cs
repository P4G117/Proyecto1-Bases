using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Patrocinador
    {
        /*
        public Patrocinador()
        {
            PatrocinadorCarrera = new HashSet<PatrocinadorCarrera>();
            PatrocinadorReto = new HashSet<PatrocinadorReto>();
        }*/

        public int IdPatrocinador { get; set; }
        public string Nombre { get; set; }
        public string Representante { get; set; }
        public decimal Numrepresentante { get; set; }
        public string Logo { get; set; }
        /*
        public virtual ICollection<PatrocinadorCarrera> PatrocinadorCarrera { get; set; }
        public virtual ICollection<PatrocinadorReto> PatrocinadorReto { get; set; }
        */
    }
}
