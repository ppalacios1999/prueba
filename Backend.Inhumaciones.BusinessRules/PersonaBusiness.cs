using Backend.Inhumaciones.Entities.Interface.Repository;
using Backend.Inhumaciones.Entities.Models.Inhumaciones;
using Backend.Inhumaciones.Entities.Responses;
using Backend.Inhumaciones.Utilities.Telemetry;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class PersonaBusiness : Entities.Interface.Business.IPersonaBusiness
    {
        /// <summary>
        /// The usuario business
        /// </summary>
        private readonly Entities.Interface.Business.IUsuarioBusiness UsuarioBusiness;

        /// <summary>
        /// The repository inhumaciones
        /// </summary>
        private readonly IBaseRepositoryInhumaciones<Persona> RepositoryInhumaciones;

        /// <summary>
        /// The telemetry exception
        /// </summary>
        private readonly ITelemetryException TelemetryException;

        /// <summary>
        /// Initializes a new instance of the <see cref="PersonaBusiness"/> class.
        /// </summary>
        /// <param name="telemetryException">The telemetry exception.</param>
        /// <param name="repositoryInhumaciones">The repository inhumaciones.</param>
        /// <param name="usuarioBusiness">The usuario business.</param>
        public PersonaBusiness(ITelemetryException telemetryException,
                               IBaseRepositoryInhumaciones<Persona> repositoryInhumaciones,
                               Entities.Interface.Business.IUsuarioBusiness usuarioBusiness)
        {
            TelemetryException = telemetryException;
            RepositoryInhumaciones = repositoryInhumaciones;
            UsuarioBusiness = usuarioBusiness;
        }

        /// <summary>
        /// Adds the persona.
        /// </summary>
        /// <param name="persona">The persona.</param>
        /// <returns></returns>
        public async Task<ResponseBase<Persona>> AddPersona(Persona persona)
        {
            try
            {
                //almacena persona
                await RepositoryInhumaciones.AddAsync(persona);

                //envia invitacion Azure AD

                //almacena usuario
                await UsuarioBusiness.AddUsuario(new Usuarios
                {
                    IdPersona = persona.IdPersona,
                    Perfil = "2",
                    Username = persona.Email,
                    Password = "7c222fb2927d828af22f592134e8932480637c0d",
                    Estado = "AC",
                    FechaTerminos = DateTime.Now,
                    Tramites = "2"
                });

                return new ResponseBase<Persona>(HttpStatusCode.OK, message: "Solicitud OK", data: persona);

            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new ResponseBase<Persona>(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
