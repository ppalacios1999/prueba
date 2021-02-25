using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class DepartamentoBusiness : Entities.Interface.Business.IDepartamentoBusiness
    {
        /// <summary>
        /// The repository departamento
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrDepartamento> RepositoryDepartamento;
        /// <summary>
        /// Initializes a new instance of the <see cref="DepartamentoBusiness"/> class.
        /// </summary>
        /// <param name="repositoryDepartamento">The repository departamento.</param>
        public DepartamentoBusiness(Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrDepartamento> repositoryDepartamento)
        {
            RepositoryDepartamento = repositoryDepartamento;
        }
        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrDepartamento>> AddDepartamento(Entities.Models.Inhumaciones.PrDepartamento departamento)
        {
            throw new NotImplementedException();
        }
        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrDepartamento>> DeteleDepartamento(string iddepartamento)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the depatamento.
        /// </summary>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrDepartamento>>> GetDepartamento()
        {
            try
            {
                var departamento = await RepositoryDepartamento.GetAllAsync();

                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrDepartamento>>(code: System.Net.HttpStatusCode.OK, message: "Solicitud ok", data: departamento.ToList(), count: departamento.Count());
            }
            catch (Exception)
            {
                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrDepartamento>>(System.Net.HttpStatusCode.InternalServerError, "Error en el servidor!");
            }
        }
        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrDepartamento>> UpdateDepatamento(Entities.Models.Inhumaciones.PrDepartamento departamento)
        {
            throw new NotImplementedException();
        }
    }
}
