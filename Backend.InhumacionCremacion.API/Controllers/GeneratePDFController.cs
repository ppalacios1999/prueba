using Backend.InhumacionCremacion.Entities.Interface.Business;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.API.Controllers
{
    /// <summary>
    /// GeneratePDFController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class GeneratePDFController : ControllerBase
    {
        /// <summary>
        /// The generate PDF business
        /// </summary>
        private readonly IGeneratePDFBusiness _generatePDFBusiness;

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratePDFController"/> class.
        /// </summary>
        /// <param name="generatePDFBusiness">The generate PDF business.</param>
        public GeneratePDFController(IGeneratePDFBusiness generatePDFBusiness)
        {
            _generatePDFBusiness = generatePDFBusiness;
        }

        /// <summary>
        /// Generates the PDF.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GeneratePDF")]
        public async Task<ActionResult> GeneratePDF()
        {
            var result = await _generatePDFBusiness.GeneratePDF();

            return new FileStreamResult(result.Data, "application/pdf");
        }
    }
}
