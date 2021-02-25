namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxResoluciones
    {
        public int IdResolucion { get; set; }
        public int Anio { get; set; }
        public string CodiTramite { get; set; }
        public int IdTramite { get; set; }
        public int? IdArchivo { get; set; }
        public string CodigoVerificacion { get; set; }
        public int Estado { get; set; }
    }
}
