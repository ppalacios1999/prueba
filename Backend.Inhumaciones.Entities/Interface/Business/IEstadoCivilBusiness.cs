using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// IEstadoCivilBusiness
    /// </summary>
    public interface IEstadoCivilBusiness
    {
        /// <summary>
        /// Adds the estadocivil.
        /// </summary>
        /// <param name="estadocivil">The estadocivil.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEstadocivil>> AddEstadoCivil(Entities.Models.Inhumaciones.PrEstadocivil estadocivil);
        /// <summary>
        /// Deletes the estadocivil.
        /// </summary>
        /// <param name="idestadocivil">The idestadocivil.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEstadocivil>> DeleteEstadoCivil(string idestadocivil);
        /// <summary>
        /// Gets the estadocivil.
        /// </summary>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrEstadocivil>>> GetEstadoCivil();
        /// <summary>
        /// Adds the update.
        /// </summary>
        /// <param name="estadocivil">The estadocivil.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEstadocivil>> UpdateEstadoCivil(Entities.Models.Inhumaciones.PrEstadocivil estadocivil);
    }
}
