using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.API.Controllers
{
    /// <summary>
    /// AdministracionController
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.ControllerBase" />
    [Route("api/[controller]")]
    [ApiController]
    public class AdministracionController : ControllerBase
    {
        #region Attributes
        /// <summary>
        /// The modulo business
        /// </summary>
        private readonly Entities.Interface.Business.IModuloBusiness ModuloBusiness;
        /// <summary>
        /// The menu business
        /// </summary>
        private readonly Entities.Interface.Business.IMenuBusiness MenuBusiness;
        #endregion

        #region Constructor       
        /// <summary>
        /// Initializes a new instance of the <see cref="AdministracionController"/> class.
        /// </summary>
        /// <param name="moduloBusiness">The modulo business.</param>
        /// <param name="menuBusiness">The modulo business.</param>
        public AdministracionController(Entities.Interface.Business.IModuloBusiness moduloBusiness,
                                        Entities.Interface.Business.IMenuBusiness menuBusiness)
        {
            ModuloBusiness = moduloBusiness;
            MenuBusiness = menuBusiness;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Adds the modulo.
        /// </summary>
        /// <param name="modulo">The modulo.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddModulo")]
        public async Task<ActionResult> AddModulo([FromBody] Entities.Models.Administracion.Modulo modulo)
        {

            var result = await ModuloBusiness.AddModulo(modulo);
            return StatusCode(result.Code, result);
        }

        /// <summary>
        /// Gets the modulo.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetModulo")]
        public async Task<ActionResult> GetModulo()
        {
            var result = await ModuloBusiness.GetModulo();
            return StatusCode(result.Code, result);
        }

        /// <summary>
        /// Updates the modulo.
        /// </summary>
        /// <param name="modulo">The modulo.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateModulo")]
        public async Task<ActionResult> UpdateModulo([FromBody] Entities.Models.Administracion.Modulo modulo)
        {
            var result = await ModuloBusiness.UpdateModulo(modulo);
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Deletes the modulo.
        /// </summary>
        /// <param name="idmodulo">The idmodulo.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteModulo")]
        public async Task<ActionResult> DeleteModulo(string idmodulo)
        {
            var result = await ModuloBusiness.DeleteModulo(idmodulo);
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Adds the menu.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddMenu")]
        public async Task<ActionResult> AddMenu([FromBody] Entities.Models.Administracion.Menu menu)
        {

            var result = await MenuBusiness.AddMenu(menu);
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Gets the menu.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetMenu")]
        public async Task<ActionResult> GetMenu()
        {
            var result = await MenuBusiness.GetMenu();
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Updates the menu.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("UpdateMenu")]
        public async Task<ActionResult> UpdateMenu([FromBody] Entities.Models.Administracion.Menu menu)
        {
            var result = await MenuBusiness.UpdateMenu(menu);
            return StatusCode(result.Code, result);
        }
        /// <summary>
        /// Deletes the menu.
        /// </summary>
        /// <param name="idmenu">The idmenu.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteMenu")]
        public async Task<ActionResult> DeleteMenu(string idmenu)
        {
            var result = await MenuBusiness.DeleteMenu(idmenu);
            return StatusCode(result.Code, result);
        }
        #endregion

    }
}
