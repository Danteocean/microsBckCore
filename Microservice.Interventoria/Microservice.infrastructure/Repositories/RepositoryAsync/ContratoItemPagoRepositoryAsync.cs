using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync
{
    public class ContratoItemPagoRepositoryAsync : GenericRepository<ContratoItemPago>
	{
		public ContratoItemPagoRepositoryAsync(MicroServiceContext microServiceContext) : base(microServiceContext) { }
	}
}
