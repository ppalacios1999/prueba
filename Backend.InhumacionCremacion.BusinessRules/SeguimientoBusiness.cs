using Backend.InhumacionCremacion.Entities.Models.InhumacionCremacion;
using Backend.InhumacionCremacion.Entities.Responses;
using Backend.InhumacionCremacion.Utilities.Telemetry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.BusinessRules
{
    public class SeguimientoBusiness : Entities.Interface.Business.ISeguimientoBusiness
    {

        #region Attributes

        /// <summary>
        /// The telemetry exception
        /// </summary>
        private readonly ITelemetryException _telemetryException;

        /// <summary>
        /// _repositorySeguimiento
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Seguimiento> _repositorySeguimiento;

        #endregion


        #region Constructor

        /// <summary>
        /// SeguimientoBusiness
        /// </summary>
        /// <param name="telemetryException"></param>
        /// <param name="repositorySeguimiento"></param>
        public SeguimientoBusiness(ITelemetryException telemetryException,
                                   Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Seguimiento> repositorySeguimiento)
        {
            _telemetryException = telemetryException;
            _repositorySeguimiento = repositorySeguimiento;
        }

        #endregion

        #region Methods
        /// <summary>
        /// AddSeguimiento
        /// </summary>
        /// <param name="seguimiento"></param>
        /// <returns></returns>
        public async Task<ResponseBase<bool>> AddSeguimiento(Seguimiento seguimiento)
        {
            try
            {
                if (seguimiento == null) { return new ResponseBase<bool>(code: HttpStatusCode.OK, message: "Los Campos son obligatorios", data: false); }
                await _repositorySeguimiento.AddAsync(new Seguimiento
                {
                    Id = Guid.NewGuid(),
                    Estado = seguimiento.Estado,
                    FechaRegistro = DateTime.Now,
                    Usuario = seguimiento.Usuario,
                    Observacion = seguimiento.Observacion
                });

                return new ResponseBase<bool>(code: HttpStatusCode.OK, message: "Solicitud OK", data: true);
            }
            catch (System.Exception ex)
            {
                _telemetryException.RegisterException(ex);
                return new ResponseBase<bool>(code: HttpStatusCode.InternalServerError, message: ex.Message, data: false);
            }
        }

        /// <summary>
        /// GetSeguimientoBySolicitud
        /// </summary>
        /// <param name="idSolicitud"></param>
        /// <returns></returns>
        public async Task<ResponseBase<List<Seguimiento>>> GetSeguimientoBySolicitud(string idSolicitud)
        {
            try
            {
                var resutl = await _repositorySeguimiento.GetAllAsync(x => x.IdSolicitud.Equals(Guid.Parse(idSolicitud)));

                if (resutl.Count() < 0)
                {
                    return new ResponseBase<List<Seguimiento>>(HttpStatusCode.OK, message: "No se econtraron resultados");
                }
                return new ResponseBase<List<Seguimiento>>(HttpStatusCode.OK, message: "Solicitud OK", data: resutl.ToList(), count: resutl.Count());
            }
            catch (Exception ex)
            {
                _telemetryException.RegisterException(ex);
                return new ResponseBase<List<Seguimiento>>(code: HttpStatusCode.InternalServerError, message: ex.Message);
            }
        }
        #endregion
    }
}
