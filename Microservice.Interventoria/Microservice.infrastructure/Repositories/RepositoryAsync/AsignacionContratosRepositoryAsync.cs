using Microservice.core.Entities;
using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync
{
	public class AsignacionContratosRepositoryAsync : GenericRepository<AsignacionContratos>
	{
		public AsignacionContratosRepositoryAsync(MicroServiceContext microServiceContext) : base(microServiceContext)
		{

		}
	}
}
