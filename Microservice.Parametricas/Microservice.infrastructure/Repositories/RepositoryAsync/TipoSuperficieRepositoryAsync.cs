using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync
{
    public class TipoSuperficieRepositoryAsync : GenericRepository<TipoSuperficie>
	{
		public TipoSuperficieRepositoryAsync(MicroServiceContext microServiceContext) : base(microServiceContext)
		{

		}
	}
}