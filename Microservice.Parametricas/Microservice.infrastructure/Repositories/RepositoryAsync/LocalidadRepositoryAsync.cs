using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync
{
    public class LocalidadRepositoryAsync : GenericRepository<Localidad>
    {

        public LocalidadRepositoryAsync(MicroServiceContext microServiceContext) : base(microServiceContext)
        {

        }
    }
}