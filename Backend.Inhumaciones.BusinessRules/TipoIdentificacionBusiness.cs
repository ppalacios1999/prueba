using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class TipoIdentificacionBusiness : Entities.Interface.Business.ITipoIdentificacionBusiness
    {
        /// <summary>
        /// The repository tipo identificacion
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrTipoidentificacion> RepositoryTipoIdentificacion;
        /// <summary>
        /// Initializes a new instance of the <see cref="TipoIdentificacionBusiness"/> class.
        /// </summary>
        /// <param name="repositoryTipoIdentificacion">The repository tipo identificacion.</param>
        public TipoIdentificacionBusiness(Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrTipoidentificacion> repositoryTipoIdentificacion)
        {
            RepositoryTipoIdentificacion = repositoryTipoIdentificacion;
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrTipoidentificacion>> AddTipoIdentificacion(Entities.Models.Inhumaciones.PrTipoidentificacion tipoIdentificacion)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrTipoidentificacion>> DeteleTipoIdentificacion(string idTipoIdentificacion)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the tipo identificacion.
        /// </summary>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrTipoidentificacion>>> GetTipoIdentificacion()
        {
            try
            {
                var tipoidentificacion = await RepositoryTipoIdentificacion.GetAllAsync();

                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrTipoidentificacion>>(code: System.Net.HttpStatusCode.OK, message: "Solicitud ok", data: tipoidentificacion.ToList(), count: tipoidentificacion.Count());
            }
            catch (Exception)
            {

                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrTipoidentificacion>>(System.Net.HttpStatusCode.InternalServerError, "Error en el servidor!");
            }
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrTipoidentificacion>> UpdateTipoIdentificacion(Entities.Models.Inhumaciones.PrTipoidentificacion tipoidentificacion)
        {
            throw new NotImplementedException();
        }
    }
}
