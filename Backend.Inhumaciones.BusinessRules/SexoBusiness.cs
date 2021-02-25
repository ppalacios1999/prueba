using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Inhumaciones.BusinessRules
{
    public class SexoBusiness : Entities.Interface.Business.ISexoBusiness
    {
        /// <summary>
        /// The repository sexo
        /// </summary>
        private readonly Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrSexo> RepositorySexo;
        /// <summary>
        /// The telemetry exception
        /// </summary>
        private readonly Utilities.Telemetry.ITelemetryException TelemetryException;
        /// <summary>
        /// Initializes a new instance of the <see cref="SexoBusiness"/> class.
        /// </summary>
        /// <param name="repositorySexo">The repository sexo.</param>
        public SexoBusiness(Entities.Interface.Repository.IBaseRepositoryInhumaciones<Entities.Models.Inhumaciones.PrSexo> repositorySexo,
                            Utilities.Telemetry.ITelemetryException telemetryException)
        {
            RepositorySexo = repositorySexo;
            TelemetryException = telemetryException;
        }
        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrSexo>> AddSexo(Entities.Models.Inhumaciones.PrSexo sexo)
        {
            throw new NotImplementedException();
        }

        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrSexo>> DeleteSexo(string idsexo)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the sexo.
        /// </summary>
        /// <returns></returns>
        public async Task<Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrSexo>>> GetSexo()
        {
            try
            {
                var sexo = await RepositorySexo.GetAllAsync();

                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrSexo>>(code: System.Net.HttpStatusCode.OK, message: "Solicitud ok", data: sexo.ToList(), count: sexo.Count());
            }
            catch (Exception ex)
            {
                TelemetryException.RegisterException(ex);
                return new Entities.Responses.ResponseBase<List<Entities.Models.Inhumaciones.PrSexo>>(code: System.Net.HttpStatusCode.InternalServerError, message: "Error en el servidor!");
            }

        }
        public Task<Entities.Responses.ResponseBase<Entities.Models.Inhumaciones.PrSexo>> UpdateSexo(Entities.Models.Inhumaciones.PrSexo sexo)
        {
            throw new NotImplementedException();
        }
    }
}
