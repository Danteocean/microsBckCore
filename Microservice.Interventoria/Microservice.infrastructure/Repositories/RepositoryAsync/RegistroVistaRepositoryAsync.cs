using Microservice.core.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync;

public class RegistroVistaRepositoryAsync: GenericRepository<RegistroVista>
{
    public RegistroVistaRepositoryAsync(MicroServiceContext microServiceContext):base(microServiceContext)
    {

    }
}