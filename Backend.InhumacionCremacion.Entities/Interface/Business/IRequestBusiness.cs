using Backend.InhumacionCremacion.Entities.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Backend.InhumacionCremacion.Entities.Interface.Business
{
    public interface IRequestBusiness
    {
        /// <summary>
        /// Adds the request.
        /// </summary>
        /// <param name="requestDTO">The request dto.</param>
        /// <returns></returns>
        Task<ResponseBase<string>> AddRequest(DTOs.RequestDTO requestDTO);

        /// <summary>
        /// GetRequestByIdUser
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        Task<ResponseBase<DTOs.RequestDetailDTO>> GetRequestByIdUser(string idUser);

        Task<ResponseBase<List<Models.InhumacionCremacion.Solicitud>>> GetRequestById(string idSolicitud);
    }
}
