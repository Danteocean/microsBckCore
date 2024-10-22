using Microservice.core.Features.RegistroVisita;
using Microservice.core.Interface.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.core;

public static class ServiceRegistration
{
    public static void AddCoreLayer(this IServiceCollection services)
    {
        services.AddTransient<IinterventoriaService, RegistroVisitaService>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}
