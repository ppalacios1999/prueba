namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class PrPrestadorservicio
    {
        public int IdPrestadorServicio { get; set; }
        public int IdSubRed { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public virtual PrSubred IdSubRedNavigation { get; set; }
    }
}
