using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync
{
    public class ItemPagoRepositoryAsync : GenericRepository<ItemPago>
    {

        public ItemPagoRepositoryAsync(MicroServiceContext microServiceContext) : base(microServiceContext)
        {

        }
    }
}