using Backend.InhumacionCremacion.Entities.Interface.Business;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.API.Controllers
{
    /// <summary>
    /// SeguimientoController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class SeguimientoController : ControllerBase
    {
        #region Attributes        
        /// <summary>
        /// The request business
        /// </summary>
        private readonly ISeguimientoBusiness SeguimientoBusiness;

        #endregion

        #region Cosnstructor                
        /// <summary>
        /// SeguimientoController
        /// </summary>
        /// <param name="seguimientoBusiness"></param>
        public SeguimientoController(ISeguimientoBusiness seguimientoBusiness)
        {
            SeguimientoBusiness = seguimientoBusiness;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// AddSeguimiento
        /// </summary>
        /// <param name="seguimiento"></param>
        /// <returns></returns>
        [HttpPost("AddSeguimiento")]
        public async Task<ActionResult> AddSeguimiento([FromBody] Entities.Models.InhumacionCremacion.Seguimiento seguimiento)
        {
            var result = await SeguimientoBusiness.AddSeguimiento(seguimiento);
            return StatusCode(result.Code, result);
        }

        /// <summary>
        /// GetSeguimientoBySolicitud
        /// </summary>
        /// <param name="idSolicitud"></param>
        /// <returns></returns>
        [HttpGet("GetSeguimientoBySolicitud/{idSolicitud}")]
        public async Task<ActionResult> GetSeguimientoBySolicitud(string idSolicitud)
        {
            var result = await SeguimientoBusiness.GetSeguimientoBySolicitud(idSolicitud);
            return StatusCode(result.Code, result);
        }
        #endregion
    }
}
