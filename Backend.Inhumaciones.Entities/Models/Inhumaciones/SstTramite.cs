namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class SstTramite
    {
        public int IdTramite { get; set; }
        public int IdUsuario { get; set; }
        public int TipoTramite { get; set; }
        public int IdEstado { get; set; }
        public int FechaCreacion { get; set; }
        public int? IdMotivoModificacion { get; set; }
        public int? IdDeptoRenovacion { get; set; }
        public int? IdMpioRenovacion { get; set; }
        public int? IdLicenciaAnt { get; set; }
    }
}
