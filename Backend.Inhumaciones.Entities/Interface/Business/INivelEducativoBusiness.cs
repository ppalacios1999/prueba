using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// INivelEducativo
    /// </summary>
    public interface INivelEducativoBusiness
    {
        /// <summary>
        /// Adds the nivel educativo.
        /// </summary>
        /// <param name="niveleducativo">The niveleducativo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrNiveleducativo>> AddNivelEducativo(Entities.Models.Inhumaciones.PrNiveleducativo niveleducativo);
        /// <summary>
        /// Deletes the nivel educativo.
        /// </summary>
        /// <param name="idniveleducativo">The idniveleducativo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrNiveleducativo>> DeleteNivelEducativo(string idniveleducativo);
        /// <summary>
        /// Gets the nivel educativo.
        /// </summary>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrNiveleducativo>>> GetNivelEducativo();
        /// <summary>
        /// Updates the get nivel educativo.
        /// </summary>
        /// <param name="niveleducativo">The niveleducativo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrNiveleducativo>> UpdateGetNivelEducativo(Entities.Models.Inhumaciones.PrNiveleducativo niveleducativo);
    }
}
