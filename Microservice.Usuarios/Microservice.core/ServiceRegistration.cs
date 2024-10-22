using Microservice.core.Features;
using Microservice.core.Interface.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.core;

public static class ServiceRegistration
{
    public static void AddCoreLayer(this IServiceCollection services)
    {
        services.AddTransient<IUsuarioService, UsuarioService>();
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    }
}
