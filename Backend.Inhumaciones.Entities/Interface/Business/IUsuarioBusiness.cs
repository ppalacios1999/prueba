using Backend.Inhumaciones.Entities.Models.Inhumaciones;
using Backend.Inhumaciones.Entities.Responses;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    public interface IUsuarioBusiness
    {
        /// <summary>
        /// Adds the usuario.
        /// </summary>
        /// <param name="usuario">The usuario.</param>
        /// <returns></returns>
        Task<ResponseBase<bool>> AddUsuario(Usuarios usuario);
    }
}
