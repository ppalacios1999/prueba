using Backend.InhumacionCremacion.Entities.Interface.Business;
using Backend.InhumacionCremacion.Entities.Responses;
using Backend.InhumacionCremacion.Utilities.Telemetry;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.BusinessRules
{
    /// <summary>
    /// AddRequest
    /// </summary>
    /// <seealso cref="Backend.InhumacionCremacion.Entities.Interface.Business.IRequestBusiness" />
    public class RequestBusiness : IRequestBusiness
    {
        #region Attributes

        /// <summary>
        /// The telemetry exception
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
        /// Initializes a new instance of the <see cref="RequestBusiness"/> class.
        /// </summary>
        /// <param name="telemetryException">The telemetry exception.</param>
        /// <param name="repositorySolicitud">The repository solicitud.</param>
        /// <param name="repositoryDatosCementerio">The repository datos cementerio.</param>
        /// <param name="repositoryInstitucionCertificaFallecimiento">The repository institucion certifica fallecimiento.</param>
        /// <param name="repositoryLugarDefuncion">The repository lugar defuncion.</param>
        /// <param name="repositoryPersona">The repository persona.</param>
        /// <param name="repositoryUbicacionPersona">The repository ubicacion persona.</param>
        public RequestBusiness(ITelemetryException telemetryException,
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
        /// Adds the request.
        /// </summary>
        /// <param name="requestDTO">The request dto.</param>
        /// <returns></returns>
        public async Task<ResponseBase<string>> AddRequest(Entities.DTOs.RequestDTO requestDTO)
        {
            try
            {
                //datos cementerio
                Guid IdDatosCementerio = Guid.NewGuid();
                await _repositoryDatosCementerio.AddAsync(new Entities.Models.InhumacionCremacion.DatosCementerio
                {
                    IdDatosCementerio = IdDatosCementerio,
                    EnBogota = requestDTO.Solicitud.DatosCementerio.EnBogota,
                    FueraBogota = requestDTO.Solicitud.DatosCementerio.FueraBogota,
                    Cementerio = requestDTO.Solicitud.DatosCementerio.Cementerio,
                    OtroSitio = requestDTO.Solicitud.DatosCementerio.OtroSitio,
                    Ciudad = requestDTO.Solicitud.DatosCementerio.Ciudad,
                    IdPais = requestDTO.Solicitud.DatosCementerio.IdPais,
                    IdDepartamento = requestDTO.Solicitud.DatosCementerio.IdDepartamento,
                    IdMunicipio = requestDTO.Solicitud.DatosCementerio.IdMunicipio
                });

                //institucion que certifica el fallecemiento
                Guid IdInstitucionCertificaFallecimiento = Guid.NewGuid();

                await _repositoryInstitucionCertificaFallecimiento.AddAsync(new Entities.Models.InhumacionCremacion.InstitucionCertificaFallecimiento
                {
                    IdInstitucionCertificaFallecimiento = IdInstitucionCertificaFallecimiento,
                    TipoIdentificacion = requestDTO.Solicitud.InstitucionCertificaFallecimiento.TipoIdentificacion,
                    NumeroIdentificacion = requestDTO.Solicitud.InstitucionCertificaFallecimiento.NumeroIdentificacion,
                    RazonSocial = requestDTO.Solicitud.InstitucionCertificaFallecimiento.RazonSocial,
                    NumeroProtocolo = requestDTO.Solicitud.InstitucionCertificaFallecimiento.NumeroProtocolo,
                    NumeroActaLevantamiento = requestDTO.Solicitud.InstitucionCertificaFallecimiento.NumeroActaLevantamiento,
                    FechaActa = requestDTO.Solicitud.InstitucionCertificaFallecimiento.FechaActa,
                    SeccionalFiscalia = requestDTO.Solicitud.InstitucionCertificaFallecimiento.SeccionalFiscalia,
                    NoFiscal = requestDTO.Solicitud.InstitucionCertificaFallecimiento.NoFiscal,
                    IdTipoInstitucion = requestDTO.Solicitud.InstitucionCertificaFallecimiento.IdTipoInstitucion,
                });

                //lugar de defuncion
                Guid IdLugarDefuncion = Guid.NewGuid();
                await _repositoryLugarDefuncion.AddAsync(new Entities.Models.InhumacionCremacion.LugarDefuncion
                {
                    IdLugarDefuncion = IdLugarDefuncion,
                    IdPais = requestDTO.Solicitud.LugarDefuncion.IdPais,
                    IdDepartamento = requestDTO.Solicitud.LugarDefuncion.IdDepartamento,
                    IdMunicipio = requestDTO.Solicitud.LugarDefuncion.IdMunicipio,
                    IdAreaDefuncion = requestDTO.Solicitud.LugarDefuncion.IdAreaDefuncion,
                    IdSitioDefuncion = requestDTO.Solicitud.LugarDefuncion.IdSitioDefuncion

                });

                //almacenamiento datos de la solicitud
                Guid IdSolicitud = Guid.NewGuid();
                await _repositorySolicitud.AddAsync(new Entities.Models.InhumacionCremacion.Solicitud
                {
                    IdSolicitud = IdSolicitud,
                    NumeroCertificado = requestDTO.Solicitud.NumeroCertificado,
                    FechaDefuncion = requestDTO.Solicitud.FechaDefuncion,
                    SinEstablecer = requestDTO.Solicitud.SinEstablecer,
                    Hora = requestDTO.Solicitud.Hora,
                    IdSexo = requestDTO.Solicitud.IdSexo,
                    FechaSolicitud = DateTime.Now,
                    EstadoSolicitud = requestDTO.Solicitud.EstadoSolicitud,
                    IdPersonaVentanilla = requestDTO.Solicitud.IdPersonaVentanilla,
                    IdUsuarioSeguridad = requestDTO.Solicitud.IdUsuarioSeguridad,
                    IdTramite = requestDTO.Solicitud.IdTramite,
                    IdLugarDefuncion = IdLugarDefuncion,
                    IdTipoMuerte = requestDTO.Solicitud.IdTipoMuerte,
                    IdDatosCementerio = IdDatosCementerio,
                    IdInstitucionCertificaFallecimiento = IdInstitucionCertificaFallecimiento
                });

                //ubicacion persona
                // en el front, para los valores nulos se debe enciar el siguiente valor: "00000000-0000-0000-0000-000000000000"
                Guid IdUbicacionPersona = Guid.Empty;

                foreach (var personas in requestDTO.Solicitud.Persona)
                {
                    if (personas.IdTipoPersona == Guid.Parse("00000000-0000-0000-0000-000000000001") &&
                        requestDTO.Solicitud.UbicacionPersona.IdPaisResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.Solicitud.UbicacionPersona.IdDepartamentoResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.Solicitud.UbicacionPersona.IdCiudadResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.Solicitud.UbicacionPersona.IdLocalidadResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.Solicitud.UbicacionPersona.IdAreaResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000") &&
                        requestDTO.Solicitud.UbicacionPersona.IdBarrioResidencia != Guid.Parse("00000000-0000-0000-0000-000000000000"))
                    {// si el tipo de persona es madre y los valores son diferentes de: "00000000-0000-0000-0000-000000000000" se inserta la ubicacion
                        IdUbicacionPersona = Guid.NewGuid();
                        await _repositoryUbicacionPersona.AddAsync(new Entities.Models.InhumacionCremacion.UbicacionPersona
                        {
                            IdUbicacionPersona = IdUbicacionPersona,
                            IdPaisResidencia = requestDTO.Solicitud.UbicacionPersona.IdPaisResidencia,
                            IdDepartamentoResidencia = requestDTO.Solicitud.UbicacionPersona.IdDepartamentoResidencia,
                            IdCiudadResidencia = requestDTO.Solicitud.UbicacionPersona.IdCiudadResidencia,
                            IdLocalidadResidencia = requestDTO.Solicitud.UbicacionPersona.IdLocalidadResidencia,
                            IdAreaResidencia = requestDTO.Solicitud.UbicacionPersona.IdAreaResidencia,
                            IdBarrioResidencia = requestDTO.Solicitud.UbicacionPersona.IdBarrioResidencia,
                        });

                        await _repositoryPersona.AddAsync(new Entities.Models.InhumacionCremacion.Persona
                        {
                            IdPersona = Guid.NewGuid(),
                            TipoIdentificacion = personas.TipoIdentificacion,
                            NumeroIdentificacion = personas.NumeroIdentificacion,
                            PrimerNombre = personas.PrimerNombre,
                            SegundoNombre = personas.SegundoNombre,
                            PrimerApellido = personas.PrimerApellido,
                            SegundoApellido = personas.SegundoApellido,
                            FechaNacimiento = personas.FechaNacimiento,
                            Nacionalidad = personas.Nacionalidad,
                            OtroParentesco = personas.OtroParentesco,
                            Estado = true,
                            IdEstadoCivil = personas.IdEstadoCivil,
                            IdNivelEducativo = personas.IdNivelEducativo,
                            IdEtnia = personas.IdEtnia,
                            IdRegimen = personas.IdRegimen,
                            IdTipoPersona = personas.IdTipoPersona,
                            IdSolicitud = IdSolicitud,
                            IdParentesco = personas.IdParentesco,
                            IdLugarExpedicion = personas.IdLugarExpedicion,
                            IdTipoProfesional = personas.IdTipoProfesional,
                            IdUbicacionPersona = IdUbicacionPersona
                        });

                    }
                    else // si el tipo de persona es diferente de la madre no tiene ubicacion
                    {
                        IdUbicacionPersona = Guid.Empty;

                        await _repositoryPersona.AddAsync(new Entities.Models.InhumacionCremacion.Persona
                        {
                            IdPersona = Guid.NewGuid(),
                            TipoIdentificacion = personas.TipoIdentificacion,
                            NumeroIdentificacion = personas.NumeroIdentificacion,
                            PrimerNombre = personas.PrimerNombre,
                            SegundoNombre = personas.SegundoNombre,
                            PrimerApellido = personas.PrimerApellido,
                            SegundoApellido = personas.SegundoApellido,
                            FechaNacimiento = personas.FechaNacimiento,
                            Nacionalidad = personas.Nacionalidad,
                            OtroParentesco = personas.OtroParentesco,
                            Estado = true,
                            IdEstadoCivil = personas.IdEstadoCivil,
                            IdNivelEducativo = personas.IdNivelEducativo,
                            IdEtnia = personas.IdEtnia,
                            IdRegimen = personas.IdRegimen,
                            IdTipoPersona = personas.IdTipoPersona,
                            IdSolicitud = IdSolicitud,
                            IdParentesco = personas.IdParentesco,
                            IdLugarExpedicion = personas.IdLugarExpedicion,
                            IdTipoProfesional = personas.IdTipoProfesional,
                            IdUbicacionPersona = IdUbicacionPersona
                        });
                    }
                }
                return new ResponseBase<string>(code: System.Net.HttpStatusCode.OK, message: "Solicitud OK", data: IdSolicitud.ToString());
            }
            catch (Exception ex)
            {
                _telemetryException.RegisterException(ex);
                throw;
            }
        }



        public async Task<ResponseBase<List<Entities.Models.InhumacionCremacion.Solicitud>>> GetRequestById(string idSolicitud)
        {
            try
            {
                var result = await _repositorySolicitud.GetAllAsync(predicate: p => p.IdSolicitud.Equals(Guid.Parse(idSolicitud)), include: inc => inc
                                                                                                                                   .Include(i => i.IdDatosCementerioNavigation)
                                                                                                                                   .Include(i => i.IdInstitucionCertificaFallecimientoNavigation));

                var personaDB = _repositoryPersona.GetAllAsync(p => p.IdSolicitud.Equals(Guid.Parse("10A94D2D-20FF-4DBB-B1F0-3C07202FF121")));

                return new ResponseBase<List<Entities.Models.InhumacionCremacion.Solicitud>>(code: System.Net.HttpStatusCode.OK, message: "Solicitud OK", data: result.ToList());
            }
            catch (Exception ex)
            {
                _telemetryException.RegisterException(ex);
                return new ResponseBase<List<Entities.Models.InhumacionCremacion.Solicitud>>(code: System.Net.HttpStatusCode.InternalServerError, message: ex.Message);
            }
        }

        /// <summary>
        /// GetRequestByIdUser
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public async Task<ResponseBase<Entities.DTOs.RequestDetailDTO>> GetRequestByIdUser(string idUser)
        {
            try
            {
                var result = await _repositorySolicitud.GetAsync(predicate: p => p.IdUsuarioSeguridad.Equals(Guid.Parse(idUser)));

                if (result == null)
                {
                    return new ResponseBase<Entities.DTOs.RequestDetailDTO>(code: System.Net.HttpStatusCode.OK, message: "No se encontraron resultados");
                }

                var resultDTO = new Entities.DTOs.RequestDetailDTO
                {
                    CodigoTramite = result.IdTramite,
                    EstadoSolicitud = result.EstadoSolicitud.ToString(),
                    FechaSolicitud = result.FechaSolicitud,
                    NumeroCertificado = result.NumeroCertificado,
                    IdPersonaVentanilla = result.IdPersonaVentanilla
                };

                return new ResponseBase<Entities.DTOs.RequestDetailDTO>(code: System.Net.HttpStatusCode.OK, message: "Solicitud ok", data: resultDTO);
            }
            catch (Exception ex)
            {
                _telemetryException.RegisterException(ex);
                return new ResponseBase<Entities.DTOs.RequestDetailDTO>(code: System.Net.HttpStatusCode.InternalServerError, message: ex.Message);
            }


        }
        #endregion
    }
}
