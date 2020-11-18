using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Grupo
    {
        /*
        public Grupo()
        {
            DeportistaGrupo = new HashSet<DeportistaGrupo>();
            GrupoCarrera = new HashSet<GrupoCarrera>();
            GrupoReto = new HashSet<GrupoReto>();
        }
        */
<<<<<<< Updated upstream

        public int IdGrupo { get; set; }
        public string Nombre { get; set; }
        public string Administrador { get; set; }
=======
        public int idgrupo { get; set; }
        public string nombre { get; set; }
        public string administrador { get; set; }
>>>>>>> Stashed changes
        /*
        public virtual Organizador AdministradorNavigation { get; set; }
        public virtual ICollection<DeportistaGrupo> DeportistaGrupo { get; set; }
        public virtual ICollection<GrupoCarrera> GrupoCarrera { get; set; }
        public virtual ICollection<GrupoReto> GrupoReto { get; set; }
        */
    }
}
