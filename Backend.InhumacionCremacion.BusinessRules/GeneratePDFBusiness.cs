using Backend.InhumacionCremacion.Entities.Interface.Business;
using Backend.InhumacionCremacion.Entities.Responses;
using Backend.InhumacionCremacion.Utilities.Telemetry;
using Microsoft.EntityFrameworkCore;
using System;
using System.Net;
using System.Threading.Tasks;
using Wkhtmltopdf.NetCore;

namespace Backend.InhumacionCremacion.BusinessRules
{
    public class GeneratePDFBusiness : IGeneratePDFBusiness
    {
        /// <summary>
        /// The generate PDF
        /// </summary>
        readonly IGeneratePdf _generatePdf;

        /// <summary>
        /// The telemetry exception
        /// </summary>
        private readonly ITelemetryException _telemetryException;

        /// <summary>
        /// _repositorySolicitud
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.Solicitud> _repositorySolicitud;

        /// <summary>
        /// _repositoryPersona
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.Persona> _repositoryPersona;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePDFBusiness"/> class.
        /// </summary>
        /// <param name="telemetryException">The telemetry exception.</param>
        /// <param name="generatePdf">The generate PDF.</param>
        public GeneratePDFBusiness(ITelemetryException telemetryException,
                                   IGeneratePdf generatePdf,
                                   Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.Solicitud> repositorySolicitud,
                                   Entities.Interface.Repository.IBaseRepositoryInhumacionCremacion<Entities.Models.InhumacionCremacion.Persona> repositoryPersona)
        {
            _telemetryException = telemetryException;
            _generatePdf = generatePdf;
            _repositorySolicitud = repositorySolicitud;
            _repositoryPersona = repositoryPersona;
        }

        /// <summary>
        /// GeneratePDF
        /// </summary>
        /// <param name="idSolicitud"></param>
        /// <returns></returns>
        public async Task<ResponseBase<dynamic>> GeneratePDF(string idSolicitud)
        {
            try
            {

                //var resultSolicitud = await _repositorySolicitud.GetAllAsync(predicate: p => p.IdSolicitud.Equals(Guid.Parse(idSolicitud)), include: inc => inc
                //                                                                                                     .Include(i => i.IdDatosCementerioNavigation)
                //                                                                                                     .Include(i => i.IdInstitucionCertificaFallecimientoNavigation)
                //                                                                                                     .Include(i => i.Persona));

                //datos generales

                //fechaActual
                //hora
                //numeroLicencia
                //certificadoDefuncion
                //funeraria
                //datos del tramitador nombres apellidos

                //datos del fallecido
                //nombres y apellidos
                //fecha fallecido
                //tipo de identificacion
                //Hora
                //muerte
                //genero
                //numero de documento
                //edad






                var datoSolitud = await _repositorySolicitud.GetAsync(w => w.IdSolicitud.Equals(System.Guid.Parse(idSolicitud)));

                var datosPersonaFallecida = await _repositoryPersona.GetAsync(w => w.IdSolicitud.Equals(System.Guid.Parse(idSolicitud)) && w.IdTipoPersona.Equals(Guid.Parse("342d934b-c316-46cb-a4f3-3aac5845d246")));

                var datosMedico = await _repositoryPersona.GetAsync(w => w.IdSolicitud.Equals(System.Guid.Parse(idSolicitud)) && w.IdTipoPersona.Equals(Guid.Parse("d8b0250b-2991-42a0-a672-8e3e45985500")));

                var data = new Entities.DTOs.DetallePdfDto
                {
                    Edad = Utilities.ConvertTypes.GetEdad(Convert.ToDateTime(datosPersonaFallecida.FechaNacimiento)),
                    CertificadoDefuncion = datoSolitud.NumeroCertificado,
                    FechaActual = DateTime.Now.ToString("dd/MM/yyyy"),
                    Hora = DateTime.Now.ToString("hh:mm:ss"),
                    FechaFallecido = datoSolitud.FechaDefuncion,
                    NumeroLicencia = "111111111",
                    Funeraria = "por definir",
                    FullNameFallecido = datosPersonaFallecida.PrimerNombre + " " + datosPersonaFallecida.SegundoNombre + " " + datosPersonaFallecida.PrimerApellido + " " + datosPersonaFallecida.SegundoApellido,
                    FullNameTramitador = "por definir",
                    FullNameMedico = datosMedico.PrimerNombre + " " + datosMedico.SegundoNombre + " " + datosMedico.PrimerApellido + " " + datosMedico.SegundoApellido
                };

                var pdf = await _generatePdf.GetByteArray("Views/Report.cshtml", data);

                var pdfStream = new System.IO.MemoryStream();

                pdfStream.Write(pdf, 0, pdf.Length);

                pdfStream.Position = 0;

                return new ResponseBase<dynamic>(code: HttpStatusCode.OK, message: "Solicitud OK", data: pdfStream);

            }
            catch (System.Exception ex)
            {
                _telemetryException.RegisterException(ex);
                return new Entities.Responses.ResponseBase<dynamic>(code: HttpStatusCode.InternalServerError, message: ex.Message);
            }
        }
    }
}
