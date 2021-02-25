using System;


namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class AprobacionLicencia
    {
        public int Idaprobacion { get; set; }
        public int? IdlicenciaExhumacion { get; set; }
        public int? Revisado { get; set; }
        public int? Aprobado { get; set; }
        public string ControlDocum { get; set; }
        public int? NumeroLicExhu { get; set; }
        public DateTime? FechaAprob { get; set; }
        public string NombreDifunto { get; set; }
        public int? NumDocdifunto { get; set; }
        public int? NumCertdefunsion { get; set; }
        public string Cementerio { get; set; }
        public int? NumLicenciaInhumacion { get; set; }
        public DateTime? FechaInhumacion { get; set; }
        public string NumeroVerificacion { get; set; }
        public string Observacionesp { get; set; }
        public string Observaciones { get; set; }
        public int? IdArchivo { get; set; }
        public bool? EstadoApro { get; set; }
    }
}
