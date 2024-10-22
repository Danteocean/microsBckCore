using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync
{
    public class TipoIntervencionRepositoryAsync : GenericRepository<TipoIntervencion>
    {

        public TipoIntervencionRepositoryAsync(MicroServiceContext microServiceContext) : base(microServiceContext)
        {

        }
    }
}