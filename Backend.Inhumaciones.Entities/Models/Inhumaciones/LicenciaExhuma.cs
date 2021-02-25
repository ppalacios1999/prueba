using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class LicenciaExhuma
    {
        public int IdlicenciaExhumacion { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public int? IdPersona { get; set; }
        public string NumeroRegdefuncion { get; set; }
        public string NumeroLicencia { get; set; }
        public string NumeroDocfallecido { get; set; }
        public int? PdfCedulasolicitante { get; set; }
        public int? PdfCertificadocementerio { get; set; }
        public int? PdfOrdenjudicial { get; set; }
        public int? PdfAutorizacionfiscal { get; set; }
        public int? PdfCertificadoPer4 { get; set; }
        public int? PdfCertificadoPer3 { get; set; }
        public int? PdfOtro { get; set; }
        public int? Estado { get; set; }
        public string Parentesco { get; set; }
        public DateTime? FechaInhumacion { get; set; }
        public short? IntervieneMedlegal { get; set; }
        public string DeclaracionJuramentada { get; set; }
    }
}
