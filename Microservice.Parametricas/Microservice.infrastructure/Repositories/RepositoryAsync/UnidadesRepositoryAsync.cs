using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync
{
    public class UnidadesRepositoryAsync : GenericRepository<Unidades>
	{
		public UnidadesRepositoryAsync(MicroServiceContext microServiceContext) : base(microServiceContext)
		{

		}
	}
}