using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Inhumaciones.API.Controllers
{
    /// <summary>
    /// CommonsController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class CommonsController : ControllerBase
    {
        #region Attributes
        /// <summary>
        /// The tipo identificacion business
        /// </summary>
        private readonly Entities.Interface.Business.ITipoIdentificacionBusiness TipoIdentificacionBusiness;
        /// <summary>
        /// The pais business
        /// </summary>
        private readonly Entities.Interface.Business.IPaisBusiness PaisBusiness;
        /// <summary>
        /// The departamento business
        /// </summary>
        private readonly Entities.Interface.Business.IDepartamentoBusiness DepartamentoBusiness;
        /// <summary>
        /// The etnia business
        /// </summary>
        private readonly Entities.Interface.Business.IEtniaBusiness EtniaBusiness;
        /// <summary>
        /// The estado civil business
        /// </summary>
        private readonly Entities.Interface.Business.IEstadoCivilBusiness EstadoCivilBusiness;
        /// <summary>
        /// The nivel educativo business
        /// </summary>
        private readonly Entities.Interface.Business.INivelEducativoBusiness NivelEducativoBusiness;
        /// <summary>
        /// The sexo business
        /// </summary>
        private readonly Entities.Interface.Business.ISexoBusiness SexoBusiness;
        #endregion

        #region Constructor                                             
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonsController"/> class.
        /// </summary>
        /// <param name="tipoIdentificacionBusiness">The tipo identificacion business.</param>
        /// <param name="paisBusiness">The pais business.</param>
        /// <param name="departamentoBusiness">The departamento business.</param>
        /// <param name="etniaBusiness">The etnia business.</param>
        /// <param name="estadoCivilBusiness">The estado civil business.</param>
        /// <param name="nivelEducativoBusiness">The nivel educativo business.</param>
        /// <param name="sexoBusiness">The sexo business.</param>
        public CommonsController(Entities.Interface.Business.ITipoIdentificacionBusiness tipoIdentificacionBusiness,
                                 Entities.Interface.Business.IPaisBusiness paisBusiness,
                                 Entities.Interface.Business.IDepartamentoBusiness departamentoBusiness,
                                 Entities.Interface.Business.IEtniaBusiness etniaBusiness,
                                 Entities.Interface.Business.IEstadoCivilBusiness estadoCivilBusiness,
                                 Entities.Interface.Business.INivelEducativoBusiness nivelEducativoBusiness,
                                 Entities.Interface.Business.ISexoBusiness sexoBusiness)
        {
            TipoIdentificacionBusiness = tipoIdentificacionBusiness;
            PaisBusiness = paisBusiness;
            DepartamentoBusiness = departamentoBusiness;
            EtniaBusiness = etniaBusiness;
            EstadoCivilBusiness = estadoCivilBusiness;
            NivelEducativoBusiness = nivelEducativoBusiness;
            SexoBusiness = sexoBusiness;
        }
        #endregion

        #region Methods            
        /// <summary>
        /// Gets the tipo identificacion.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetTipoIdentificacion")]
        public async Task<ActionResult> GetTipoIdentificacion()
        {
            var result = await TipoIdentificacionBusiness.GetTipoIdentificacion();
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Gets the pais.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetPais")]
        public async Task<ActionResult> GetPais()
        {
            var result = await PaisBusiness.GetPais();
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Gets the departamento.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetDepartamento")]
        public async Task<ActionResult> GetDepartamento()
        {
            var result = await DepartamentoBusiness.GetDepartamento();
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Gets the etnia.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEtnia")]
        public async Task<ActionResult> GetEtnia()
        {
            var result = await EtniaBusiness.GetEtnia();
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Gets the estado civil.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetEstadoCivil")]
        public async Task<ActionResult> GetEstadoCivil()
        {
            var result = await EstadoCivilBusiness.GetEstadoCivil();
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Gets the nivel educativo.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetNivelEducativo")]
        public async Task<ActionResult> GetNivelEducativo()
        {
            var result = await NivelEducativoBusiness.GetNivelEducativo();
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Gets the sexo.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSexo")]
        public async Task<ActionResult> GetSexo()
        {
            var result = await SexoBusiness.GetSexo();
            return StatusCode(result.Code, result);
        }
        #endregion

    }
}
