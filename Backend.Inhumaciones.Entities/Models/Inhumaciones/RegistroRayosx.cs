using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RegistroRayosx
    {
        public int IdRegistro { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaTramite { get; set; }
        public int Estado { get; set; }
    }
}
