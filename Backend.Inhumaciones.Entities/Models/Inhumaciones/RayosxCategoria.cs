using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxCategoria
    {
        public int IdCategoriaRayosx { get; set; }
        public int IdTramiteRayosx { get; set; }
        public int Categoria { get; set; }
        public int? Categoria1 { get; set; }
        public int? Categoria11 { get; set; }
        public int? Categoria12 { get; set; }
        public int? Categoria2 { get; set; }
        public int TipoVisualizacion { get; set; }
        public int Estado { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
