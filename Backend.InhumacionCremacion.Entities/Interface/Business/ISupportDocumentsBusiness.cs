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
    }
}
