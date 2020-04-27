using Microsoft.Extensions.DependencyInjection;
using WSVentas.Data.Entities;
using WSVentas.Data.Repository;

namespace WSVentas.Data.DataManager
{
    public static class AdministradorDeDatosServices
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IDataRepository<Cliente>, ClienteManager>();

            return services;
        }
    }
}
