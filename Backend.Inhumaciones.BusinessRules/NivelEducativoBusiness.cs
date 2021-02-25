using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class NivelEducativoBusiness : Entities.Interface.Business.INivelEducativoBusiness
    {
        /// <summary>
        /// The repository nivel educativo
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrNiveleducativo> RepositoryNivelEducativo;
        /// <summary>
        /// Initializes a new instance of the <see cref="NivelEducativoBusiness"/> class.
        /// </summary>
        /// <param name="repositoryNivelEducativo">The repository nivel educativo.</param>
        public NivelEducativoBusiness(Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrNiveleducativo> repositoryNivelEducativo)
        {
            RepositoryNivelEducativo = repositoryNivelEducativo;
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrNiveleducativo>> AddNivelEducativo(Entities.Models.Inhumaciones.PrNiveleducativo niveleducativo)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrNiveleducativo>> DeleteNivelEducativo(string idniveleducativo)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the nivel educativo.
        /// </summary>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrNiveleducativo>>> GetNivelEducativo()
        {
            try
            {
                var niveleducativo = await RepositoryNivelEducativo.GetAllAsync();
                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrNiveleducativo>>(code: System.Net.HttpStatusCode.OK, message: "Solicitud ok", data: niveleducativo.ToList(), count: niveleducativo.Count());
            }
            catch (Exception)
            {

                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrNiveleducativo>>(code: System.Net.HttpStatusCode.InternalServerError, "Error en el servidor!");
            }
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrNiveleducativo>> UpdateGetNivelEducativo(Entities.Models.Inhumaciones.PrNiveleducativo niveleducativo)
        {
            throw new NotImplementedException();
        }
    }
}
