using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class PrFaqtips
    {
        public int IdFaq { get; set; }
        public int IdTramite { get; set; }
        public bool TipoFaqs { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public string Tips { get; set; }
        public string Categoria { get; set; }
        public bool? Estado { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
