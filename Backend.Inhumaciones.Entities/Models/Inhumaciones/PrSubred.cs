using System.Collections.Generic;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class PrSubred
    {
        public PrSubred()
        {
            PrPrestadorservicio = new HashSet<PrPrestadorservicio>();
        }

        public int IdSubRed { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<PrPrestadorservicio> PrPrestadorservicio { get; set; }
    }
}
