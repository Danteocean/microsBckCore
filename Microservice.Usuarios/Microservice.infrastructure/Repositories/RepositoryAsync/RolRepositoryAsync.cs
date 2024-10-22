using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync;

public class RolRepositoryAsync: GenericRepository<Rol>
{
    public RolRepositoryAsync(MicroServiceContext microServiceContext):base(microServiceContext)
    {

    }
}