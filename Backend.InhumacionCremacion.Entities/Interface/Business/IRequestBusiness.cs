using Backend.InhumacionCremacion.Entities.DTOs;
using Backend.InhumacionCremacion.Entities.Responses;
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
        Task<ResponseBase<bool>> AddRequest(RequestDTO requestDTO);

        /// <summary>
        /// GetRequestByIdUser
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        Task<ResponseBase<dynamic>> GetRequestByIdUser(string idUser);
    }
}
