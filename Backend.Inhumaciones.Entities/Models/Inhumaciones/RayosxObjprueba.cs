using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxObjprueba
    {
        public int IdObjRayosx { get; set; }
        public int IdTramiteRayosx { get; set; }
        public string ObjNombre { get; set; }
        public string ObjMarca { get; set; }
        public string ObjModelo { get; set; }
        public string ObjSerie { get; set; }
        public string ObjCalibracion { get; set; }
        public int ObjVigencia { get; set; }
        public string ObjFecha { get; set; }
        public int ObjManual { get; set; }
        public string ObjUso { get; set; }
        public int Estado { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
