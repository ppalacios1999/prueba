using Backend.InhumacionCremacion.Entities.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.Entities.Interface.Business
{
    public interface ISupportDocumentsBusiness
    {
        /// <summary>
        /// Adds the support documents.
        /// </summary>
        /// <param name="requestSupportDocumentsDTOs">The request support documents dt os.</param>
        /// <returns></returns>
        Task<ResponseBase<bool>> AddSupportDocuments(List<DTOs.RequestSupportDocumentsDTO> requestSupportDocumentsDTOs);
        /// <summary>
        /// Gets all suport by request identifier.
        /// </summary>
        /// <param name="IdSolicitud">The identifier solicitud.</param>
        /// <returns></returns>
        Task<ResponseBase<List<Models.InhumacionCremacion.DocumentosSoporte>>> GetAllSuportByRequestId(string IdSolicitud);
    }
}
