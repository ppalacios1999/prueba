using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// IEtnia
    /// </summary>
    public interface IEtniaBusiness
    {
        /// <summary>
        /// Adds the etnia.
        /// </summary>
        /// <param name="etnia">The etnia.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEtnia>> AddEtnia(Entities.Models.Inhumaciones.PrEtnia etnia);
        /// <summary>
        /// Deletes the etnia.
        /// </summary>
        /// <param name="idetinia">The idetinia.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEtnia>> DeleteEtnia(string idetinia);
        /// <summary>
        /// Gets the etnia.
        /// </summary>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrEtnia>>> GetEtnia();
        /// <summary>
        /// Updates the etnia.
        /// </summary>
        /// <param name="etnia">The etnia.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEtnia>> UpdateEtnia(Entities.Models.Inhumaciones.PrEtnia etnia);
    }
}
