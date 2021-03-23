using Backend.Inhumaciones.Entities.Interface.Repository;
using Backend.Inhumaciones.Entities.Models.Inhumaciones;
using Backend.Inhumaciones.Entities.Responses;
using Backend.Inhumaciones.Utilities.Telemetry;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class UsuarioBusiness : Entities.Interface.Business.IUsuarioBusiness
    {

        /// <summary>
        /// The repository usuarios
        /// </summary>
        private readonly IBaseRepositoryInhumaciones<Usuarios> RepositoryUsuarios;

        /// <summary>
        /// The telemetry exception
        /// </summary>
        private readonly ITelemetryException TelemetryException;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioBusiness"/> class.
        /// </summary>
        /// <param name="telemetryException">The telemetry exception.</param>
        /// <param name="repositoryUsuarios">The repository usuarios.</param>
        public UsuarioBusiness(ITelemetryException telemetryException,
                               IBaseRepositoryInhumaciones<Usuarios> repositoryUsuarios)
        {
            TelemetryException = telemetryException;
            RepositoryUsuarios = repositoryUsuarios;
        }

        public async Task<ResponseBase<bool>> AddUsuario(Usuarios usuario)
        {
            try
            {
                await RepositoryUsuarios.AddAsync(usuario);
                return new ResponseBase<bool>(HttpStatusCode.OK, message: "Solicitud OK", data: true);
            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new ResponseBase<bool>(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
