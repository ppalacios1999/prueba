using Backend.InhumacionCremacion.Entities.Interface.Business;
using Backend.InhumacionCremacion.Entities.Responses;
using Backend.InhumacionCremacion.Utilities.Telemetry;
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
        /// Initializes a new instance of the <see cref="GeneratePDFBusiness"/> class.
        /// </summary>
        /// <param name="telemetryException">The telemetry exception.</param>
        /// <param name="generatePdf">The generate PDF.</param>
        public GeneratePDFBusiness(ITelemetryException telemetryException,
                                   IGeneratePdf generatePdf)
        {
            _telemetryException = telemetryException;
            _generatePdf = generatePdf;
        }

        /// <summary>
        /// Generates the PDF.
        /// </summary>
        /// <returns></returns>
        public async Task<ResponseBase<dynamic>> GeneratePDF()
        {
            try
            {
                //var html = @"<!DOCTYPE html>
                //        <html>
                //        <head>
                //        </head>
                //        <body>
                //            <header>
                //                <h1>This is a hardcoded test</h1>
                //            </header>
                //            <div>
                //                <h2>456789</h2>

                //            </div>

                //        </body>";

                var pdf = await _generatePdf.GetByteArray("Views/Test_Form.cshtml");
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
