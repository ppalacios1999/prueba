using System;

namespace Backend.Inhumaciones.Entities.Models.Inhumaciones
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public string Perfil { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaTerminos { get; set; }
        public string Tramites { get; set; }
    }
}
