using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.API.Controllers
{
    /// <summary>
    /// SupportDocumentsController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class SupportDocumentsController : ControllerBase
    {
        #region Attributes                
        /// <summary>
        /// The request business
        /// </summary>
        private readonly Entities.Interface.Business.ISupportDocumentsBusiness _supportDocumentsBusiness;
        #endregion

        #region Cosnstructor                        
        /// <summary>
        /// Initializes a new instance of the <see cref="SupportDocumentsController"/> class.
        /// </summary>
        /// <param name="supportDocumentsBusiness">The support documents business.</param>
        public SupportDocumentsController(Entities.Interface.Business.ISupportDocumentsBusiness supportDocumentsBusiness)
        {
            _supportDocumentsBusiness = supportDocumentsBusiness;
        }
        #endregion

        #region Methods                        
        /// <summary>
        /// Adds the support documents.
        /// </summary>
        /// <param name="requestSupportDocumentsDTO">The request support documents dto.</param>
        /// <returns></returns>
        [HttpPost("AddSupportDocuments")]
        public async Task<ActionResult> AddSupportDocuments([FromBody] List<Entities.DTOs.RequestSupportDocumentsDTO> requestSupportDocumentsDTO)
        {
            var result = await _supportDocumentsBusiness.AddSupportDocuments(requestSupportDocumentsDTO);
            return StatusCode(result.Code, result);
        }

        /// <summary>
        /// Adds the support documents.
        /// </summary>
        /// <param name="IdSolicitud">The identifier solicitud.</param>
        /// <returns></returns>
        [HttpGet("GetAllSuportByRequestId/{IdSolicitud}")]
        public async Task<ActionResult> GetAllSuportByRequestId(string IdSolicitud)
        {
            var result = await _supportDocumentsBusiness.GetAllSuportByRequestId(IdSolicitud);
            return StatusCode(result.Code, result);
        }
        #endregion
    }
}
