using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxToe
    {
        public int IdToeRayosx { get; set; }
        public int IdTramiteRayosx { get; set; }
        public string ToePnombre { get; set; }
        public string ToeSnombre { get; set; }
        public string ToePapellido { get; set; }
        public string ToeSapellido { get; set; }
        public int ToeTdocumento { get; set; }
        public string ToeNdocumento { get; set; }
        public string ToeLexpedicion { get; set; }
        public string ToeCorreo { get; set; }
        public string ToeProfesion { get; set; }
        public int ToeNivel { get; set; }
        public string ToeUltEntrenamiento { get; set; }
        public string ToeProEntrenamiento { get; set; }
        public string ToeRegistro { get; set; }
        public int ToeTipo { get; set; }
        public int Estado { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
