using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class SstTramiteFlujo
    {
        public ulong Id { get; set; }
        public ulong TramiteId { get; set; }
        public int IdUsuario { get; set; }
        public int IdEstado { get; set; }
        public DateTime FechaEstado { get; set; }
        public string Observaciones { get; set; }
        public int IdArchivo { get; set; }
    }
}
