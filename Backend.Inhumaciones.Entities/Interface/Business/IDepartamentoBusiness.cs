using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// IDepartamentoBusiness
    /// </summary>
    public interface IDepartamentoBusiness
    {
        /// <summary>
        /// Adds the departamento.
        /// </summary>
        /// <param name="departamento">The departamento.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrDepartamento>> AddDepartamento(Entities.Models.Inhumaciones.PrDepartamento departamento);
        /// <summary>
        /// Deteles the departamento.
        /// </summary>
        /// <param name="iddepartamento">The iddepartamento.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrDepartamento>> DeteleDepartamento(string iddepartamento);
        /// <summary>
        /// Gets the depatamento.
        /// </summary>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrDepartamento>>> GetDepartamento();
        /// <summary>
        /// Updates the depatamento.
        /// </summary>
        /// <param name="departamento">The departamento.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrDepartamento>> UpdateDepatamento(Entities.Models.Inhumaciones.PrDepartamento departamento);
    }
}


