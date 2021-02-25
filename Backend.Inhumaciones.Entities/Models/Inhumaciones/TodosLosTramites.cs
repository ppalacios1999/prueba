using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class TodosLosTramites
    {
        public int IdTitulo { get; set; }
        public DateTime FechaTramite { get; set; }
        public int TipoTitulo { get; set; }
        public int Estado { get; set; }
        public string DescEstado { get; set; }
        public string DescTipoIden { get; set; }
        public long NumeIdentificacion { get; set; }
        public string PNombre { get; set; }
        public string SNombre { get; set; }
        public string PApellido { get; set; }
        public string SApellido { get; set; }
        public DateTime? FechReso { get; set; }
    }
}
