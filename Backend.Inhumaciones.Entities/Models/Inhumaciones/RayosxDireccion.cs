using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxDireccion
    {
        public int IdDireccionRayosx { get; set; }
        public int IdTramiteRayosx { get; set; }
        public string DireEntidad { get; set; }
        public string SedeEntidad { get; set; }
        public string EmailEntidad { get; set; }
        public int DeptoEntidad { get; set; }
        public int MpioEntidad { get; set; }
        public string CelularEntidad { get; set; }
        public string IndicativoEntidad { get; set; }
        public string TelefonoEntidad { get; set; }
        public string ExtensionEntidad { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
