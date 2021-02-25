using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxDirector
    {
        public int IdDirectorRayosx { get; set; }
        public int IdTramiteRayosx { get; set; }
        public string TalentoPnombre { get; set; }
        public string TalentoSnombre { get; set; }
        public string TalentoPapellido { get; set; }
        public string TalentoSapellido { get; set; }
        public int TalentoTdocumento { get; set; }
        public string TalentoNdocumento { get; set; }
        public string TalentoLexpedicion { get; set; }
        public string TalentoCorreo { get; set; }
        public string TalentoTitulo { get; set; }
        public string TalentoUniversidad { get; set; }
        public string TalentoLibro { get; set; }
        public string TalentoRegistro { get; set; }
        public string TalentoFechaDiploma { get; set; }
        public string TalentoResolucion { get; set; }
        public string TalentoFechaConvalida { get; set; }
        public string TalentoNivel { get; set; }
        public string TalentoTituloPos { get; set; }
        public string TalentoUniversidadPos { get; set; }
        public string TalentoLibroPos { get; set; }
        public string TalentoRegistroPos { get; set; }
        public string TalentoFechaDiplomaPos { get; set; }
        public string TalentoResolucionPos { get; set; }
        public string TalentoFechaConvalidaPos { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
