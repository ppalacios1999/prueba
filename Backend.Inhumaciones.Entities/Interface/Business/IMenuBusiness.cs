using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// IMenu
    /// </summary>
    public interface IMenuBusiness
    {
        /// <summary>
        /// Adds the menu.
        /// </summary>
        /// <param name="menu">The modulo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>> AddMenu(Entities.Models.Administracion.Menu menu);
        /// <summary>
        /// Deletes the menu.
        /// </summary>
        /// <param name="idmenu">The idmenu.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>> DeleteMenu(string idmenu);
        /// <summary>
        /// Gets the menu.
        /// </summary>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<List<Entities.Models.Administracion.Menu>>> GetMenu();
        /// <summary>
        /// Updates the menu.
        /// </summary>
        /// <param name="menu">The menu.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Menu>> UpdateMenu(Entities.Models.Administracion.Menu menu);
    }
}
