using System;

namespace Backend.InhumacionCremacion.Entities.DTOs
{
    public class RequestDetailDTO
    {
        public string NumeroCertificado { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string EstadoSolicitud { get; set; }
        public Guid CodigoTramite { get; set; }
        public int IdPersonaVentanilla { get; set; }
    }
}
