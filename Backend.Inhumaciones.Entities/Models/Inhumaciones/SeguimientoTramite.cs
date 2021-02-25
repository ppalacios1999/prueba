using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class SeguimientoTramite
    {
        public int IdSeguimiento { get; set; }
        public int IdTitulo { get; set; }
        public int IdConsecutivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
        public int IdUsuario { get; set; }
        public string Observaciones { get; set; }
        public short? Tipomotivoaclaracion { get; set; }
    }
}
