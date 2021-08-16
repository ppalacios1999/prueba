using System;

namespace Backend.InhumacionCremacion.Entities.DTOs
{
    public class RequestDetailDTO
    {
        public string NumeroCertificado { get; set; }
        public DateTime FechaSolicitud { get; set; }
        public string EstadoSolicitud { get; set; }
        public int CodigoTramite { get; set; }
        public string Tramite { get; set; }
    }
}
