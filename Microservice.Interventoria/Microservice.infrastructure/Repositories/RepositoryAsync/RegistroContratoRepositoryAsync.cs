using Microservice.core.Entities;
using Microservice.domain.Entities;
using Microservice.infrastructure.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.infrastructure.Repositories.RepositoryAsync
{
	public class RegistroContratoRepositoryAsync : GenericRepository<RegistroContrato>
	{
		public RegistroContratoRepositoryAsync(MicroServiceContext microServiceContext) : base(microServiceContext) { }
	}
}
