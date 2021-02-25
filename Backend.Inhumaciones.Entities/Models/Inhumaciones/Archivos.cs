using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class Archivos
    {
        public int IdArchivo { get; set; }
        public string Ruta { get; set; }
        public string Nombre { get; set; }
        public DateTime? Fecha { get; set; }
        public string Tags { get; set; }
        public bool? EsPublico { get; set; }
        public string Estado { get; set; }
    }
}
