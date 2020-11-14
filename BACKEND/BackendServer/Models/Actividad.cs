using System;
using System.Collections.Generic;

namespace BackendServer.Models
{
    public partial class Actividad
    {
        public int IdActividad { get; set; }
        public string Nombreactividad { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Mapa { get; set; }
        public int? Kilometros { get; set; }
        public TimeSpan? Duracion { get; set; }
        public string Completitud { get; set; }
        public string TipoActividad { get; set; }
        public string IdDeportista { get; set; }

        public virtual Deportista IdDeportistaNavigation { get; set; }
    }
}
