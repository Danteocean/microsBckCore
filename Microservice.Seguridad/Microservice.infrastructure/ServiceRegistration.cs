using Microservice.core.Interface.Repositories;
using Microservice.infrastructure.Repositories;
using Microservice.infrastructure.Setting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Microservice.infrastructure;

public static class ServiceRegistration
{
    public static IServiceCollection AddDbContexts(this IServiceCollection services
        , IConfiguration configuration)
    {
        services.AddDbContext<MicroServiceContext>(options =>
        options.UseNpgsql(configuration.GetRequiredSection("ConnectionStrings").Value));

        return services;
    }

    public static IServiceCollection AddRepository(this IServiceCollection services)
    {
        services.AddTransient<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
