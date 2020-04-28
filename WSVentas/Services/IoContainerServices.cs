using Microsoft.Extensions.DependencyInjection;
using WSVentas.Services.ServiciosCliente;

namespace WSVentas.Services
{
    public static class IoContainerServices
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddSingleton<IServicioCliente, ServicioCliente>();

            return services;
        }
    }
}
