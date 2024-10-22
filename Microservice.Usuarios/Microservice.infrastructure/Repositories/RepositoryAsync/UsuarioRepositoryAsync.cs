using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;

namespace Microservice.infrastructure.Repositories.RepositoryAsync
{
    public class UsuarioRepositoryAsync : GenericRepository<Usuario>
	{
		public UsuarioRepositoryAsync(MicroServiceContext microServiceContext) : base(microServiceContext)
		{

		}
	}
}
