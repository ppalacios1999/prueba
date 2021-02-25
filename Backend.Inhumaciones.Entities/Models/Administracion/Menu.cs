using System;

namespace Backend.Inhumaciones.Entities.Models.Administracion
{
    public partial class Menu
    {
        public int IdMenu { get; set; }
        public int IdModulo { get; set; }
        public int IdMenuPadre { get; set; }
        public int IdPermiso { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public int Orden { get; set; }
        public string Icono { get; set; }
        public short Estado { get; set; }
        public int? IdUsuarioCrea { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdUsuaioModifica { get; set; }
        public DateTime? FechaModifica { get; set; }
    }
}
