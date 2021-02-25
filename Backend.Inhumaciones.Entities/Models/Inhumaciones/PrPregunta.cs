using System.Collections.Generic;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class PrPregunta
    {
        public PrPregunta()
        {
            PrOpcion = new HashSet<PrOpcion>();
        }

        public int IdPregunta { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<PrOpcion> PrOpcion { get; set; }
    }
}
