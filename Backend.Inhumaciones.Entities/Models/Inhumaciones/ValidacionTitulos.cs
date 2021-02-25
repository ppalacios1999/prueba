using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class ValidacionTitulos
    {
        public int IdValidacion { get; set; }
        public int IdTitulo { get; set; }
        public int IdEstadoTramite { get; set; }
        public DateTime Fecha { get; set; }
        public string CausalesNegacion { get; set; }
        public string OtrasCausalesNegacion { get; set; }
        public string ArgumentosRecurrente { get; set; }
        public string Consideraciones { get; set; }
        public string Consideraciones2 { get; set; }
        public string Observacion1aclaracion { get; set; }
        public string Observacion2aclaracion { get; set; }
        public string Observacion3aclaracion { get; set; }
        public string NombresapellidosErrados { get; set; }
        public string NombreProfesionnerrado { get; set; }
        public string NombreInstitucionerrado { get; set; }
        public string TipoIdentificacionerrada { get; set; }
        public DateTime? FechaTermerrada { get; set; }
        public string Articulos { get; set; }
        public int IdUsuario { get; set; }
        public string Observaciones { get; set; }
        public int IdArchivo { get; set; }
        public string CodigoVerificacion { get; set; }
    }
}
