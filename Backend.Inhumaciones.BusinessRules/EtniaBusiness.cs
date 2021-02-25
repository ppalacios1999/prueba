using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class EtniaBusiness : Entities.Interface.Business.IEtniaBusiness
    {
        /// <summary>
        /// The repository etnia
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrEtnia> RepositoryEtnia;
        /// <summary>
        /// Initializes a new instance of the <see cref="EtniaBusiness"/> class.
        /// </summary>
        /// <param name="repositoryEtnia">The repository etnia.</param>
        public EtniaBusiness(Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrEtnia> repositoryEtnia)
        {
            RepositoryEtnia = repositoryEtnia;
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEtnia>> AddEtnia(Entities.Models.Inhumaciones.PrEtnia etnia)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEtnia>> DeleteEtnia(string idetinia)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the etnia.
        /// </summary>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrEtnia>>> GetEtnia()
        {
            try
            {
                var etnia = await RepositoryEtnia.GetAllAsync();
                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrEtnia>>(code: System.Net.HttpStatusCode.OK, message: "Solicitud ok", data: etnia.ToList(), count: etnia.Count());
            }
            catch (Exception)
            {
                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrEtnia>>(System.Net.HttpStatusCode.InternalServerError, "Error en el servidor!");
            }
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEtnia>> UpdateEtnia(Entities.Models.Inhumaciones.PrEtnia etnia)
        {
            throw new NotImplementedException();
        }
    }
}
