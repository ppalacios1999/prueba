using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxTipoTramite
    {
        public uint Id { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
