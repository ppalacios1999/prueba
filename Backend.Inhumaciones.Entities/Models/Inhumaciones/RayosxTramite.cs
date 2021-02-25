using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxTramite
    {
        public ulong Id { get; set; }
        public ulong User { get; set; }
        public uint TipoTramite { get; set; }
        public bool Estado { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int Modulo1 { get; set; }
        public int Modulo2 { get; set; }
        public int Modulo3 { get; set; }
        public int Modulo4 { get; set; }
        public int Modulo5 { get; set; }
        public int VisitaPrevia { get; set; }
        public int Categoria { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public int? Notificacion { get; set; }
        public string CorreoNotificacion { get; set; }
        public DateTime? FechaSubsanacion1 { get; set; }
        public int? SolicitaProrroga { get; set; }
        public DateTime? FechaEnvioSubsanacion1 { get; set; }
        public DateTime? FechaSubsanacion2 { get; set; }
        public DateTime? FechaEnvioSubsanacion2 { get; set; }
        public int? ArchivoVisita { get; set; }
    }
}
