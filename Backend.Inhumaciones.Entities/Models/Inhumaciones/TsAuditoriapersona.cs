using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class TsAuditoriapersona
    {
        public int Id { get; set; }
        public int? IdLlave { get; set; }
        public string TablaNombre { get; set; }
        public string CampoNombre { get; set; }
        public string AnteriorNombre { get; set; }
        public string NuevoNombre { get; set; }
        public string Usuario { get; set; }
        public DateTime? Modificado { get; set; }
    }
}
