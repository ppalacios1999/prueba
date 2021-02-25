using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxEquipoInfra
    {
        public int IdEquipoInfra { get; set; }
        public int IdEquipo { get; set; }
        public int IdTramite { get; set; }
        public int IdItem { get; set; }
        public int IdEstado { get; set; }
        public string Observaciones { get; set; }
        public int IdUsuario { get; set; }
        public DateTime FechaObservacion { get; set; }
    }
}
