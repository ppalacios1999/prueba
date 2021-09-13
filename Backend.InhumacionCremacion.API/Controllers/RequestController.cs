using Backend.InhumacionCremacion.Entities.Interface.Business;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.API.Controllers
{
    /// <summary>
    /// RequestController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class RequestController : ControllerBase
    {
        #region Attributes        
        /// <summary>
        /// The request business
        /// </summary>
        private readonly IRequestBusiness RequestBusiness;
        #endregion

        #region Cosnstructor        
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestController"/> class.
        /// </summary>
        /// <param name="requestBusiness">The request business.</param>
        public RequestController(IRequestBusiness requestBusiness)
        {
            RequestBusiness = requestBusiness;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Adds the rquest.
        /// </summary>
        /// <param name="requestDTO">The request dto.</param>
        /// <returns></returns>
        [HttpPost("AddRquest")]
        public async Task<ActionResult> AddRquest([FromBody] Entities.DTOs.RequestDTO requestDTO)
        {
            var result = await RequestBusiness.AddRequest(requestDTO);
            return StatusCode(result.Code, result);
        }

        /// <summary>
        /// GetRequestByIdUser
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        [HttpGet("GetRequestByIdUser/{idUser}")]
        public async Task<ActionResult> GetRequestByIdUser(string idUser)
        {
            var result = await RequestBusiness.GetRequestByIdUser(idUser);
            return StatusCode(result.Code, result);
        }

        /// <summary>
        /// GetRequestById
        /// </summary>
        /// <param name="idSolicitud"></param>
        /// <returns></returns>
        [HttpGet("GetRequestById/{idSolicitud}")]
        public async Task<ActionResult> GetRequestById(string idSolicitud)
        {
            var result = await RequestBusiness.GetRequestById(idSolicitud);
            return StatusCode(result.Code, result);
        }

        /// <summary>
        /// Gets the code ventanilla by identifier user.
        /// </summary>
        /// <param name="idUser">The identifier user.</param>
        /// <returns></returns>
        [HttpGet("GetCodeVentanillaByIdUser/{idUser}")]
        public async Task<ActionResult> GetCodeVentanillaByIdUser(string idUser)
        {
            var result = await RequestBusiness.GetCodeVentanillaByIdUser(idUser);
            return StatusCode(result.Code, result);
        }
        #endregion
    }
}
