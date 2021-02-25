using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// IModulo
    /// </summary>
    public interface IModuloBusiness
    {
        /// <summary>
        /// Adds the modulo.
        /// </summary>
        /// <param name="modulo">The modulo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>> AddModulo(Entities.Models.Administracion.Modulo modulo);
        /// <summary>
        /// Deletes the modulo.
        /// </summary>
        /// <param name="idmodulo">The idmodulo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>> DeleteModulo(string idmodulo);
        /// <summary>
        /// Gets the modulo.
        /// </summary>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<List<Entities.Models.Administracion.Modulo>>> GetModulo();
        /// <summary>
        /// Updates the modulo.
        /// </summary>
        /// <param name="modulo">The modulo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Administracion.Modulo>> UpdateModulo(Entities.Models.Administracion.Modulo modulo);
    }
}
