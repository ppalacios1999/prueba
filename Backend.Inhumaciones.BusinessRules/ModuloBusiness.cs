using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class ModuloBusiness : Entities.Interface.Business.IModuloBusiness
    {
        /// <summary>
        /// The repository modulo
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryAdministracion<Entities.Models.Administracion.Modulo> RepositoryModulo;
        /// <summary>
        /// The telemetry exception
        /// </summary>
        private readonly Utilities.Telemetry.ITelemetryException TelemetryException;
        /// <summary>
        /// Initializes a new instance of the <see cref="ModuloBusiness"/> class.
        /// </summary>
        /// <param name="repositoryModulo">The repository modulo.</param>
        public ModuloBusiness(Entities.Interface.Repository.IBaseRepositoryAdministracion<Entities.Models.Administracion.Modulo> repositoryModulo,
                              Utilities.Telemetry.ITelemetryException telemetryException)
        {
            RepositoryModulo = repositoryModulo;
            TelemetryException = telemetryException;
        }
        /// <summary>
        /// Adds the modulo.
        /// </summary>
        /// <param name="modulo">The modulo.</param>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>> AddModulo(Entities.Models.Administracion.Modulo modulo)
        {
            try
            {
                if (modulo == null || string.IsNullOrEmpty(modulo.Nombre) || modulo.FechaCrea == null)
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.BadRequest, message: Middle.Messages.Validated);
                }
                await RepositoryModulo.AddAsync(modulo);
                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.OK, Middle.Messages.Created);
            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.InternalServerError, Middle.Messages.ServerError);
            }
        }
        /// <summary>
        /// Deletes the modulo.
        /// </summary>
        /// <param name="idmodulo">The idmodulo.</param>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>> DeleteModulo(string idmodulo)
        {
            try
            {
                if (idmodulo == null)
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.BadRequest, message: Middle.Messages.Validated);
                }
                var moduloBD = await RepositoryModulo.GetAsync(w => w.IdModulo == Convert.ToInt32(idmodulo));

                if (moduloBD == null)
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.BadRequest, Middle.Messages.Search);
                }
                moduloBD.Estado = 0;

                await RepositoryModulo.UpdateAsync(moduloBD);

                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.OK, Middle.Messages.Deleted);
            }
            catch (Exception)
            {
                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.InternalServerError, Middle.Messages.ServerError);
            }
        }
        /// <summary>
        /// Gets the modulo.
        /// </summary>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<List<Entities.Models.Administracion.Modulo>>> GetModulo()
        {
            try
            {
                var modulo = await RepositoryModulo.GetAllAsync();
                return new Entities.Responses.ResponseBase<List<Entities.Models.Administracion.Modulo>>(code: System.Net.HttpStatusCode.OK, message: Middle.Messages.GetOk, data: modulo.ToList(), count: modulo.Count());
            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new Entities.Responses.ResponseBase<List<Entities.Models.Administracion.Modulo>>(code: System.Net.HttpStatusCode.InternalServerError, message: Middle.Messages.ServerError);
            }
        }
        /// <summary>
        /// Updates the modulo.
        /// </summary>
        /// <param name="modulo">The modulo.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>> UpdateModulo(Entities.Models.Administracion.Modulo modulo)
        {
            try
            {
                if (modulo == null || modulo.FechaCrea == null || string.IsNullOrEmpty(modulo.Nombre))
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.BadRequest, message: Middle.Messages.Validated);
                }

                var moduloBD = await RepositoryModulo.GetAsync(w => w.IdModulo == modulo.IdModulo);

                if (moduloBD == null)
                {
                    return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.BadRequest, Middle.Messages.Search);
                }

                moduloBD.Nombre = modulo.Nombre;
                moduloBD.Descripcion = modulo.Descripcion;
                moduloBD.OrdenMenu = modulo.OrdenMenu;
                moduloBD.Icono = modulo.Icono;
                moduloBD.Permiso = modulo.Permiso;
                moduloBD.Estado = modulo.Estado;
                moduloBD.ModuloPadre = modulo.ModuloPadre;
                moduloBD.IdUsuarioCrea = modulo.IdUsuarioCrea;
                moduloBD.FechaCrea = modulo.FechaCrea;
                moduloBD.IdUsuModi = modulo.IdUsuModi;
                moduloBD.FechaModi = modulo.FechaModi;


                await RepositoryModulo.UpdateAsync(moduloBD);

                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.OK, Middle.Messages.Updated);
            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>(System.Net.HttpStatusCode.InternalServerError, Middle.Messages.ServerError);
            }
        }
    }
}
