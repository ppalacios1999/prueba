using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// ISexoBusiness
    /// </summary>
    public interface ISexoBusiness
    {
        /// <summary>
        /// Adds the sexo.
        /// </summary>
        /// <param name="sexo">The sexo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrSexo>> AddSexo(Entities.Models.Inhumaciones.PrSexo sexo);
        /// <summary>
        /// Deletes the sexo.
        /// </summary>
        /// <param name="idsexo">The idsexo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrSexo>> DeleteSexo(string idsexo);
        /// <summary>
        /// Gets the sexo.
        /// </summary>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrSexo>>> GetSexo();
        /// <summary>
        /// Updates the sexo.
        /// </summary>
        /// <param name="sexo">The sexo.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrSexo>> UpdateSexo(Entities.Models.Inhumaciones.PrSexo sexo);

    }
}
