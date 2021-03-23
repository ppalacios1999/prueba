using Backend.Inhumaciones.Entities.Models.Inhumaciones;
using Backend.Inhumaciones.Entities.Responses;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.Entities.Interface.Business
{
    public interface IPersonaBusiness
    {
        /// <summary>
        /// Adds the persona.
        /// </summary>
        /// <param name="persona">The persona.</param>
        /// <returns></returns>
        Task<ResponseBase<Persona>> AddPersona(Persona persona);
    }
}
