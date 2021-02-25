using System;

namespace Backend.Inhumaciones.Entities.Models.Administracion
{
    public partial class Modulo
    {
        public int IdModulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int OrdenMenu { get; set; }
        public string Icono { get; set; }
        public int Permiso { get; set; }
        public short Estado { get; set; }
        public int? ModuloPadre { get; set; }
        public int? IdUsuarioCrea { get; set; }
        public DateTime? FechaCrea { get; set; }
        public int? IdUsuModi { get; set; }
        public DateTime? FechaModi { get; set; }
       
    }
}
