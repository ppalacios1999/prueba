using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RegistroTitulo
    {
        public int IdTitulo { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaTramite { get; set; }
        public int TipoTitulo { get; set; }
        public int? InstitucionEducativa { get; set; }
        public int? Profesion { get; set; }
        public DateTime? FechaTerm { get; set; }
        public string Tarjeta { get; set; }
        public string Diploma { get; set; }
        public string Acta { get; set; }
        public string Libro { get; set; }
        public string Folio { get; set; }
        public int? Anio { get; set; }
        public string CodUniversidad { get; set; }
        public DateTime? FechaTermExt { get; set; }
        public string Resolucion { get; set; }
        public DateTime? FechaResolucion { get; set; }
        public int? Entidad { get; set; }
        public string TituloEquivalente { get; set; }
        public short? PaisTituloequi { get; set; }
        public int? PdfDocumento { get; set; }
        public int? PdfTitulo { get; set; }
        public int? PdfActa { get; set; }
        public int? PdfTarjeta { get; set; }
        public int? PdfResolucion { get; set; }
        public int Estado { get; set; }
        public short? Terminos { get; set; }
        public DateTime? FechaEditado { get; set; }
        public DateTime? FechaReposicion { get; set; }
        public DateTime? FechaAclaracion { get; set; }
    }
}
