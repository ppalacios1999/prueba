using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Backend.Inhumaciones
{
    /// <summary>
    /// Startup Data.
    /// </summary>
    public static class StartupData
    {
        /// <summary>
        /// The timeout seconds
        /// </summary>
        private const int TIMEOUT_SECONDS = 60;

        /// <summary>
        /// Configure data.
        /// </summary>
        /// <param name="services">Service Collection.</param>
        /// <param name="connectionString">Connection string.</param>
        public static void AddData(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Repositories.Context.InhumacionesContext>(options =>
            {
                options.UseMySQL(configuration.GetValue<string>(Utilities.Constants.KeyVault.SQLDBTramites),
                    sqlOptions =>
                    {
                        sqlOptions.CommandTimeout(TIMEOUT_SECONDS);

                    });
            });

            services.AddDbContext<Repositories.Context.AdministracionContext>(options =>
            {
                options.UseMySQL(configuration.GetValue<string>(Utilities.Constants.KeyVault.SQLDBAdministracion),
                    sqlOptions =>
                    {
                        sqlOptions.CommandTimeout(TIMEOUT_SECONDS);

                    });
            });
            services.AddScoped(typeof(Entities.Interface.Repository.IBaseRepositoryInhumaciones<>), typeof(Repositories.Base.BaseRepositoryInhumaciones<>));
            services.AddScoped(typeof(Entities.Interface.Repository.IBaseRepositoryAdministracion<>), typeof(Repositories.Base.BaseRepositoryAdministracion<>));
        }
    }
}
