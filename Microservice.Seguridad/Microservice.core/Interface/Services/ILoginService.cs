using Microservice.core.DTOs.Login;
using Microservice.domain.Wrappers;

namespace Microservice.core.Interface.Services;

public interface ILoginService
{
	Task<Response<Object>> GetLogin(Login login);

}