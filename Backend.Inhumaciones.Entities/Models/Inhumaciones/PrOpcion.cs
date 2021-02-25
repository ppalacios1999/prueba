namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class PrOpcion
    {
        public int IdOpcion { get; set; }
        public int IdPregunta { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }

        public virtual PrPregunta IdPreguntaNavigation { get; set; }
    }
}
