using System.Collections.Generic;
using System.Threading.Tasks;


namespace Backend.Inhumaciones.Entities.Interface.Business
{
    /// <summary>
    /// ITipoIdentificacion
    /// </summary>
    public interface ITipoIdentificacionBusiness
    {
        /// <summary>
        /// Adds the tipo identificacion.
        /// </summary>
        /// <param name="tipoIdentificacion">The tipo identificacion.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrTipoidentificacion>> AddTipoIdentificacion(Entities.Models.Inhumaciones.PrTipoidentificacion tipoIdentificacion);
        /// <summary>
        /// Deteles the tipo identificacion.
        /// </summary>
        /// <param name="idTipoIdentificacion">The identifier tipo identificacion.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrTipoidentificacion>> DeteleTipoIdentificacion(string idTipoIdentificacion);
        /// <summary>
        /// Gets the tipo identificacion.
        /// </summary>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrTipoidentificacion>>> GetTipoIdentificacion();
        /// <summary>
        /// Updates the tipo identificacion.
        /// </summary>
        /// <param name="tipoidentificacion">The tipoidentificacion.</param>
        /// <returns></returns>
        Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrTipoidentificacion>> UpdateTipoIdentificacion(Entities.Models.Inhumaciones.PrTipoidentificacion tipoidentificacion);

    }
}
