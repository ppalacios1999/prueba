using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// IPais
    /// </summary>
    public interface IPaisBusiness
    {
        /// <summary>
        /// Adds the pais.
        /// </summary>
        /// <param name="pais">The pais.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrPais>> AddPais(Entities.Models.Inhumaciones.PrPais pais);
        /// <summary>
        /// Deteles the pais.
        /// </summary>
        /// <param name="idpais">The idpais.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrPais>> DetelePais(string idpais);
        /// <summary>
        /// Gets the pais.
        /// </summary>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrPais>>> GetPais();
        /// <summary>
        /// Updates the pais.
        /// </summary>
        /// <param name="pais">The pais.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrPais>> UpdatePais(Entities.Models.Inhumaciones.PrPais pais);
    }
}