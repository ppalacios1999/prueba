using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class NotificacionExh
    {
        public int Idnotificacion { get; set; }
        public int? IdlicenciaExhumacion { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public bool? Estado { get; set; }
        public int? IdUsuario { get; set; }
        public string Observaciones { get; set; }
    }
}
