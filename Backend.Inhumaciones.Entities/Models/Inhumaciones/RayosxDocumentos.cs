using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxDocumentos
    {
        public int IdDocumentosRayosx { get; set; }
        public int IdTramiteRayosx { get; set; }
        public string Documento { get; set; }
        public string Path { get; set; }
        public int Categoria { get; set; }
        public int IdArchivo { get; set; }
        public string Estado { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
