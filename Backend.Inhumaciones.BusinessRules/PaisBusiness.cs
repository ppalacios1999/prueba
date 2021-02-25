using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class PaisBusiness : Entities.Interface.Business.IPaisBusiness
    {
        /// <summary>
        /// The repository pais
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrPais> RepositoryPais;
        /// <summary>
        /// Initializes a new instance of the <see cref="PaisBusiness"/> class.
        /// </summary>
        /// <param name="repositoryPais">The repository pais.</param>
        public PaisBusiness(Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrPais> repositoryPais)
        {
            RepositoryPais = repositoryPais;
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrPais>> AddPais(Entities.Models.Inhumaciones.PrPais pais)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrPais>> DetelePais(string idpais)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the pais.
        /// </summary>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrPais>>> GetPais()
        {
            try
            {
                var pais = await RepositoryPais.GetAllAsync();
                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrPais>>(code: System.Net.HttpStatusCode.OK, message: "Solicitud ok", data: pais.ToList(), count: pais.Count());
            }
            catch (Exception)
            {
                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrPais>>(System.Net.HttpStatusCode.InternalServerError, "Error en el servidor!");
            }
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrPais>> UpdatePais(Entities.Models.Inhumaciones.PrPais pais)
        {
            throw new NotImplementedException();
        }
    }
}
