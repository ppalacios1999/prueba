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
        public async Task<ActionResult> AddRquest(Entities.DTOs.RequestDTO requestDTO)
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

        #endregion
    }
}
