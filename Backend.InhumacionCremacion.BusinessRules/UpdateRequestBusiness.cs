using Backend.InhumacionCremacion.Entities.DTOs;
using Backend.InhumacionCremacion.Entities.Responses;
using Backend.InhumacionCremacion.Utilities.Telemetry;
using System;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.BusinessRules
{
    public class UpdateRequestBusiness : Entities.Interface.Business.IUpdateRequestBusiness
    {
        #region Attributes
        /// <summary>
        /// _telemetryException
        /// </summary>
        private readonly ITelemetryException _telemetryException;

        /// <summary>
        /// The repository ubicacion persona
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.UbicacionPersona> _repositoryUbicacionPersona;

        /// <summary>
        /// The repository persona
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.Persona> _repositoryPersona;

        /// <summary>
        /// The repository lugar defuncion
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.LugarDefuncion> _repositoryLugarDefuncion;

        /// <summary>
        /// The repository datos cementerio
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.DatosCementerio> _repositoryDatosCementerio;

        /// <summary>
        /// The repository institucion certifica fallecimiento
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.InstitucionCertificaFallecimiento> _repositoryInstitucionCertificaFallecimiento;

        /// <summary>
        /// The repository solicitud
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.Solicitud> _repositorySolicitud;

        #endregion

        #region Constructor
        /// <summary>
        /// UpdateRequestBusiness
        /// </summary>
        /// <param name="telemetryException"></param>
        /// <param name="repositoryDominio"></param>
        /// <param name="repositorySolicitud"></param>
        /// <param name="repositoryDatosCementerio"></param>
        /// <param name="repositoryInstitucionCertificaFallecimiento"></param>
        /// <param name="repositoryLugarDefuncion"></param>
        /// <param name="repositoryPersona"></param>
        /// <param name="repositoryUbicacionPersona"></param>
        public UpdateRequestBusiness(ITelemetryException telemetryException,
                                Entities.Interface.Repository.IBaseRepositoryCommons<Entities.Models.Commons.Dominio> repositoryDominio,
                                Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.Solicitud> repositorySolicitud,
                                Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.DatosCementerio> repositoryDatosCementerio,
                                Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.InstitucionCertificaFallecimiento> repositoryInstitucionCertificaFallecimiento,
                                Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.LugarDefuncion> repositoryLugarDefuncion,
                                Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.Persona> repositoryPersona,
                                Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.UbicacionPersona> repositoryUbicacionPersona)
        {
            _telemetryException = telemetryException;
            _repositorySolicitud = repositorySolicitud;
            _repositoryDatosCementerio = repositoryDatosCementerio;
            _repositoryInstitucionCertificaFallecimiento = repositoryInstitucionCertificaFallecimiento;
            _repositoryLugarDefuncion = repositoryLugarDefuncion;
            _repositoryPersona = repositoryPersona;
            _repositoryUbicacionPersona = repositoryUbicacionPersona;
        }
        #endregion


        #region Methods
        /// <summary>
        /// UpdateRequest
        /// </summary>
        /// <param name="requestDTO"></param>
        /// <returns></returns>
        public async Task<ResponseBase<string>> UpdateRequest(SolicitudDTO requestDTO)
        {
            try
            {
                if (requestDTO.DatosCementerio == null)
                {
                    return new ResponseBase<string>(code: System.Net.HttpStatusCode.BadRequest, message: "Los datos del cementerio no pueden ser nulos");
                }

                //datos cementerio
                await _repositoryDatosCementerio.UpdateAsync(new Entities.Models.InhumacionCremacion.DatosCementerio
                {
                    IdDatosCementerio = requestDTO.DatosCementerio.IdDatosCementerio,
                    EnBogota = requestDTO.DatosCementerio.EnBogota,
                    FueraBogota = requestDTO.DatosCementerio.FueraBogota,
                    Cementerio = requestDTO.DatosCementerio.Cementerio,
                    OtroSitio = requestDTO.DatosCementerio.OtroSitio,
                    Ciudad = requestDTO.DatosCementerio.Ciudad,
                    IdPais = requestDTO.DatosCementerio.IdPais,
                    IdDepartamento = requestDTO.DatosCementerio.IdDepartamento,
                    IdMunicipio = requestDTO.DatosCementerio.IdMunicipio
                });

                if (requestDTO.InstitucionCertificaFallecimiento == null)
                {
                    return new ResponseBase<string>(code: System.Net.HttpStatusCode.BadRequest, message: "Los datos de la institucion que ceritifa el fallecimiento no pueden ser nulos");
                }

                //institucion que certifica el fallecemiento
                await _repositoryInstitucionCertificaFallecimiento.AddAsync(new Entities.Models.InhumacionCremacion.InstitucionCertificaFallecimiento
                {
                    IdInstitucionCertificaFallecimiento = requestDTO.InstitucionCertificaFallecimiento.IdInstitucionCertificaFallecimiento,
                    TipoIdentificacion = requestDTO.InstitucionCertificaFallecimiento.TipoIdentificacion,
                    NumeroIdentificacion = requestDTO.InstitucionCertificaFallecimiento.NumeroIdentificacion,
                    RazonSocial = requestDTO.InstitucionCertificaFallecimiento.RazonSocial,
                    NumeroProtocolo = requestDTO.InstitucionCertificaFallecimiento.NumeroProtocolo,
                    NumeroActaLevantamiento = requestDTO.InstitucionCertificaFallecimiento.NumeroActaLevantamiento,
                    FechaActa = requestDTO.InstitucionCertificaFallecimiento.FechaActa,
                    SeccionalFiscalia = requestDTO.InstitucionCertificaFallecimiento.SeccionalFiscalia,
                    NoFiscal = requestDTO.InstitucionCertificaFallecimiento.NoFiscal,
                    IdTipoInstitucion = requestDTO.InstitucionCertificaFallecimiento.IdTipoInstitucion,
                });

                ////lugar de defuncion
                //Guid IdLugarDefuncion = Guid.NewGuid();
                //await _repositoryLugarDefuncion.AddAsync(new Entities.Models.InhumacionCremacion.LugarDefuncion
                //{
                //    IdLugarDefuncion = IdLugarDefuncion,
                //    IdPais = requestDTO.Solicitud.LugarDefuncion.IdPais,
                //    IdDepartamento = requestDTO.Solicitud.LugarDefuncion.IdDepartamento,
                //    IdMunicipio = requestDTO.Solicitud.LugarDefuncion.IdMunicipio,
                //    IdAreaDefuncion = requestDTO.Solicitud.LugarDefuncion.IdAreaDefuncion,
                //    IdSitioDefuncion = requestDTO.Solicitud.LugarDefuncion.IdSitioDefuncion

                //});

                ////almacenamiento datos de la solicitud
                //Guid IdSolicitud = Guid.NewGuid();
                //await _repositorySolicitud.AddAsync(new Entities.Models.InhumacionCremacion.Solicitud
                //{
                //    IdSolicitud = IdSolicitud,
                //    NumeroCertificado = requestDTO.Solicitud.NumeroCertificado,
                //    FechaDefuncion = requestDTO.Solicitud.FechaDefuncion,
                //    SinEstablecer = requestDTO.Solicitud.SinEstablecer,
                //    Hora = requestDTO.Solicitud.Hora,
                //    IdSexo = requestDTO.Solicitud.IdSexo,
                //    FechaSolicitud = DateTime.Now,
                //    EstadoSolicitud = requestDTO.Solicitud.EstadoSolicitud,
                //    IdPersonaVentanilla = requestDTO.Solicitud.IdPersonaVentanilla,
                //    IdUsuarioSeguridad = requestDTO.Solicitud.IdUsuarioSeguridad,
                //    IdTramite = requestDTO.Solicitud.IdTramite,
                //    IdLugarDefuncion = IdLugarDefuncion,
                //    IdTipoMuerte = requestDTO.Solicitud.IdTipoMuerte,
                //    IdDatosCementerio = IdDatosCementerio,
                //    IdInstitucionCertificaFallecimiento = IdInstitucionCertificaFallecimiento

                return new ResponseBase<string>(code: System.Net.HttpStatusCode.OK, message: "Solicitud");
            }
            catch (System.Exception ex)
            {
                _telemetryException.RegisterException(ex);
                return new ResponseBase<string>(code: System.Net.HttpStatusCode.InternalServerError, message: ex.Message);
            }
        }
        #endregion
    }
}
