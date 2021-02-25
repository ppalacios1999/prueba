namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxEncargado
    {
        public int IdEncargadoRayosx { get; set; }
        public int IdTramiteRayosx { get; set; }
        public string EncargadoPnombre { get; set; }
        public string EncargadoSnombre { get; set; }
        public string EncargadoPapellido { get; set; }
        public string EncargadoSapellido { get; set; }
        public int EncargadoTdocumento { get; set; }
        public string EncargadoNdocumento { get; set; }
        public string EncargadoLexpedicion { get; set; }
        public string EncargadoCorreo { get; set; }
        public string EncargadoProfesion { get; set; }
        public int EncargadoNivel { get; set; }
    }
}
