namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class SstRegistro
    {
        public int IdRegistro { get; set; }
        public int IdTramite { get; set; }
        public string Servicios { get; set; }
        public string Area { get; set; }
        public string Caracteristicas { get; set; }
        public string Otros { get; set; }
        public string Labora { get; set; }
        public string NombreEmpresa { get; set; }
        public string DirEmpresa { get; set; }
        public int? DeptoEmpresa { get; set; }
        public int? MpioEmpresa { get; set; }
        public string TelEmpresa { get; set; }
        public string FaxEmpresa { get; set; }
        public int? TipoPrograma { get; set; }
        public int? TipoTitulo { get; set; }
        public int? TipoProfesional { get; set; }
        public int? OtroTipoProfesional { get; set; }
        public string TituloPrograma { get; set; }
        public int? DocDocuIden { get; set; }
        public int? DocPregrado { get; set; }
        public int? DocPostgrado { get; set; }
        public int? DocConvalidacion { get; set; }
        public int? DocPensum { get; set; }
        public int? DocSoporte { get; set; }
        public int? DocCc { get; set; }
        public int? DocRl { get; set; }
        public int? DocFormatoPersonas { get; set; }
        public int? DocFormatoEquipos { get; set; }
    }
}
