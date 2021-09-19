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

                //datos cementerio ok
                await _repositoryDatosCementerio.UpdateAsync(new Entities.Models.InhumacionCremacion.DatosCementerio
                {
                    IdDatosCementerio = requestDTO.DatosCementerio.IdDatosCementerio,
                    EnBogota = requestDTO.DatosCementerio.EnBogota,
                    FueraBogota = requestDTO.DatosCementerio.FueraBogota,
                    FueraPais = requestDTO.DatosCementerio.FueraPais,
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

                //institucion que certifica el fallecemiento ok
                await _repositoryInstitucionCertificaFallecimiento.UpdateAsync(new Entities.Models.InhumacionCremacion.InstitucionCertificaFallecimiento
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

                if (requestDTO.LugarDefuncion == null)
                {
                    return new ResponseBase<string>(code: System.Net.HttpStatusCode.BadRequest, message: "Los datos del lugar de la defuncion no pueden ser nulos");
                }

                //lugar de defuncion ok
                await _repositoryLugarDefuncion.UpdateAsync(new Entities.Models.InhumacionCremacion.LugarDefuncion
                {
                    IdLugarDefuncion = requestDTO.LugarDefuncion.IdLugarDefuncion,
                    IdPais = requestDTO.LugarDefuncion.IdPais,
                    IdDepartamento = requestDTO.LugarDefuncion.IdDepartamento,
                    IdMunicipio = requestDTO.LugarDefuncion.IdMunicipio,
                    IdAreaDefuncion = requestDTO.LugarDefuncion.IdAreaDefuncion,
                    IdSitioDefuncion = requestDTO.LugarDefuncion.IdSitioDefuncion

                });

                //pendiente validacion de campos obligatorios ok
                await _repositorySolicitud.UpdateAsync(new Entities.Models.InhumacionCremacion.Solicitud
                {
                    IdSolicitud = requestDTO.IdSolicitud,
                    NumeroCertificado = requestDTO.NumeroCertificado,
                    FechaDefuncion = requestDTO.FechaDefuncion,
                    SinEstablecer = requestDTO.SinEstablecer,
                    Hora = requestDTO.Hora,
                    IdSexo = requestDTO.IdSexo,
                    FechaSolicitud = DateTime.Now,
                    EstadoSolicitud = requestDTO.EstadoSolicitud,
                    IdPersonaVentanilla = requestDTO.IdPersonaVentanilla,
                    IdUsuarioSeguridad = requestDTO.IdUsuarioSeguridad,
                    IdTramite = requestDTO.IdTramite,
                    IdLugarDefuncion = requestDTO.LugarDefuncion.IdLugarDefuncion,
                    IdTipoMuerte = requestDTO.IdTipoMuerte,
                    IdDatosCementerio = requestDTO.DatosCementerio.IdDatosCementerio,
                    IdInstitucionCertificaFallecimiento = requestDTO.InstitucionCertificaFallecimiento.IdInstitucionCertificaFallecimiento
                });

                var resultUbicacionPersona = new Entities.Models.InhumacionCremacion.UbicacionPersona();

                if (requestDTO.UbicacionPersona != null)
                {
                    resultUbicacionPersona = await _repositoryUbicacionPersona.GetAsync(p => p.IdUbicacionPersona.Equals(requestDTO.UbicacionPersona.IdUbicacionPersona));
                }

                //ubicacion persona
                foreach (var persona in requestDTO.Persona)
                {
                    if (persona.IdTipoPersona == Guid.Parse("342d934b-c316-46cb-a4f3-3aac5845d246") &&
                        requestDTO.UbicacionPersona.IdPaisResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.UbicacionPersona.IdDepartamentoResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.UbicacionPersona.IdCiudadResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.UbicacionPersona.IdLocalidadResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.UbicacionPersona.IdAreaResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.UbicacionPersona.IdBarrioResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000"))
                    {
                        // si el tipo de persona es madre y los valores son diferentes de: "00000000-0000-0000-0000-000000000000" se inserta la ubicacion

                        await _repositoryUbicacionPersona.UpdateAsync(new Entities.Models.InhumacionCremacion.UbicacionPersona
                        {
                            IdUbicacionPersona = resultUbicacionPersona.IdUbicacionPersona,
                            IdPaisResidencia = resultUbicacionPersona.IdPaisResidencia,
                            IdDepartamentoResidencia = resultUbicacionPersona.IdDepartamentoResidencia,
                            IdCiudadResidencia = resultUbicacionPersona.IdCiudadResidencia,
                            IdLocalidadResidencia = resultUbicacionPersona.IdLocalidadResidencia,
                            IdAreaResidencia = resultUbicacionPersona.IdAreaResidencia,
                            IdBarrioResidencia = resultUbicacionPersona.IdBarrioResidencia,
                        });

                        await _repositoryPersona.UpdateAsync(new Entities.Models.InhumacionCremacion.Persona
                        {
                            IdPersona = persona.IdPersona,
                            TipoIdentificacion = persona.TipoIdentificacion,
                            NumeroIdentificacion = persona.NumeroIdentificacion,
                            PrimerNombre = persona.PrimerNombre,
                            SegundoNombre = persona.SegundoNombre,
                            PrimerApellido = persona.PrimerApellido,
                            SegundoApellido = persona.SegundoApellido,
                            FechaNacimiento = persona.FechaNacimiento,
                            Nacionalidad = persona.Nacionalidad,
                            OtroParentesco = persona.OtroParentesco,
                            Estado = persona.Estado,
                            IdEstadoCivil = persona.IdEstadoCivil,
                            IdNivelEducativo = persona.IdNivelEducativo,
                            IdEtnia = persona.IdEtnia,
                            IdRegimen = persona.IdRegimen,
                            IdTipoPersona = persona.IdTipoPersona,
                            IdSolicitud = persona.IdSolicitud,
                            IdParentesco = persona.IdParentesco,
                            IdLugarExpedicion = persona.IdLugarExpedicion,
                            IdTipoProfesional = persona.IdTipoProfesional,
                            IdUbicacionPersona = persona.IdUbicacionPersona
                        });
                    }
                    else // si el tipo de persona es diferente de la madre no tiene ubicacion
                    {
                        await _repositoryPersona.UpdateAsync(new Entities.Models.InhumacionCremacion.Persona
                        {
                            IdPersona = persona.IdPersona,
                            TipoIdentificacion = persona.TipoIdentificacion,
                            NumeroIdentificacion = persona.NumeroIdentificacion,
                            PrimerNombre = persona.PrimerNombre,
                            SegundoNombre = persona.SegundoNombre,
                            PrimerApellido = persona.PrimerApellido,
                            SegundoApellido = persona.SegundoApellido,
                            FechaNacimiento = persona.FechaNacimiento,
                            Nacionalidad = persona.Nacionalidad,
                            OtroParentesco = persona.OtroParentesco,
                            Estado = persona.Estado,
                            IdEstadoCivil = persona.IdEstadoCivil,
                            IdNivelEducativo = persona.IdNivelEducativo,
                            IdEtnia = persona.IdEtnia,
                            IdRegimen = persona.IdRegimen,
                            IdTipoPersona = persona.IdTipoPersona,
                            IdSolicitud = persona.IdSolicitud,
                            IdParentesco = persona.IdParentesco,
                            IdLugarExpedicion = persona.IdLugarExpedicion,
                            IdTipoProfesional = persona.IdTipoProfesional,
                            IdUbicacionPersona = persona.IdUbicacionPersona
                        });
                    }
                }
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
