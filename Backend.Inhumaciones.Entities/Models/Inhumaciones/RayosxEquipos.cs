using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class RayosxEquipos
    {
        public int IdEquipoRayosx { get; set; }
        public int IdTramiteRayosx { get; set; }
        public int? EquipoGenerador { get; set; }
        public int Categoria1 { get; set; }
        public int Categoria2 { get; set; }
        public int Categoria11 { get; set; }
        public int Categoria12 { get; set; }
        public int? Categoria21 { get; set; }
        public string OtroEquipo { get; set; }
        public int TipoVisualizacion { get; set; }
        public string MarcaEquipo { get; set; }
        public string ModeloEquipo { get; set; }
        public string SerieEquipo { get; set; }
        public string MarcaTuboRx { get; set; }
        public string ModeloTuboRx { get; set; }
        public string SerieTuboRx { get; set; }
        public decimal TensionTuboRx { get; set; }
        public decimal ContieneTuboRx { get; set; }
        public decimal EnergiaFotones { get; set; }
        public decimal EnergiaElectrones { get; set; }
        public decimal CargaTrabajo { get; set; }
        public string UbicacionEquipo { get; set; }
        public string NumeroPermiso { get; set; }
        public string AnioFabricacion { get; set; }
        public string AnioFabricacionTubo { get; set; }
        public string MarcaTuboRx2 { get; set; }
        public string ModeloTuboRx2 { get; set; }
        public string SerieTuboRx2 { get; set; }
        public decimal? TensionTuboRx2 { get; set; }
        public decimal? ContieneTuboRx2 { get; set; }
        public decimal? EnergiaFotones2 { get; set; }
        public decimal? EnergiaElectrones2 { get; set; }
        public decimal? CargaTrabajo2 { get; set; }
        public string AnioFabricacionTubo2 { get; set; }
        public int? FiBlindajes { get; set; }
        public int? FiControlCalidad { get; set; }
        public int? FiPlano { get; set; }
        public int? FiPruebasCaracterizacion { get; set; }
        public int? FiBlindajes2 { get; set; }
        public int? FiControlCalidad2 { get; set; }
        public int? FiPruebasCaracterizacion2 { get; set; }
        public int Estado { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
