namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class PrPuntoatencion
    {
        public int IdPunto { get; set; }
        public string NombrePunto { get; set; }
        public string Direccion { get; set; }
        public string Horario { get; set; }
        public int IdSubred { get; set; }
    }
}
