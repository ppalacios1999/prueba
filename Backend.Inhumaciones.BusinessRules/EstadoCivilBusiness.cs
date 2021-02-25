using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class EstadoCivilBusiness : Entities.Interface.Business.IEstadoCivilBusiness
    {
        /// <summary>
        /// The repository estadocivil
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrEstadocivil> RepositoryEstadocivil;
        /// <summary>
        /// Initializes a new instance of the <see cref="EstadoCivilBusiness"/> class.
        /// </summary>
        /// <param name="repositoryEstadocivil">The repository estadocivil.</param>
        public EstadoCivilBusiness(Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrEstadocivil> repositoryEstadocivil)
        {
            RepositoryEstadocivil = repositoryEstadocivil;
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEstadocivil>> AddEstadoCivil(Entities.Models.Inhumaciones.PrEstadocivil estadocivil)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEstadocivil>> UpdateEstadoCivil(Entities.Models.Inhumaciones.PrEstadocivil estadocivil)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrEstadocivil>> DeleteEstadoCivil(string idestadocivil)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the estadocivil.
        /// </summary>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrEstadocivil>>> GetEstadoCivil()
        {
            try
            {
                var estadocivil = await RepositoryEstadocivil.GetAllAsync();
                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrEstadocivil>>(code: System.Net.HttpStatusCode.OK, message: "Solicitud ok", data: estadocivil.ToList(), count: estadocivil.Count());
            }
            catch (Exception)
            {
                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrEstadocivil>>(code: System.Net.HttpStatusCode.InternalServerError, "Error en el servidor!");
            }
        }
    }
}
