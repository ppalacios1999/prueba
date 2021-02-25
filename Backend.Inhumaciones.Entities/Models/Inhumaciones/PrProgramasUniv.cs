namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class PrProgramasUniv
    {
        public string IdPrograma { get; set; }
        public long IdInstitucion { get; set; }
        public string NombrePrograma { get; set; }
        public int AplicaRethus { get; set; }
        public string Sede { get; set; }
        public string TipoProg { get; set; }
    }
}
