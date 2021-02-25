using Backend.Inhumaciones.BusinessRules;
using Backend.Inhumaciones.Entities.Interface.Business;
using Microsoft.Extensions.DependencyInjection;

namespace Backend.Inhumaciones.API.Injections
{
    /// <summary>
    /// Business Injection
    /// </summary>
    public static class BusinessInjection
    {
        /// <summary>
        /// Adds the business configuration.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void AddBusinessConfig(this IServiceCollection services)
        {
            services.AddTransient<ITipoIdentificacionBusiness, TipoIdentificacionBusiness>();
            services.AddTransient<IPaisBusiness, PaisBusiness>();
            services.AddTransient<IDepartamentoBusiness, DepartamentoBusiness>();
            services.AddTransient<IEtniaBusiness, EtniaBusiness>();
            services.AddTransient<IEstadoCivilBusiness, EstadoCivilBusiness>();
            services.AddTransient<INivelEducativoBusiness, NivelEducativoBusiness>();
            services.AddTransient<ISexoBusiness, SexoBusiness>();
            services.AddTransient<IModuloBusiness, ModuloBusiness>();
            services.AddTransient<IMenuBusiness, MenuBusiness>();
        }
    }
}
