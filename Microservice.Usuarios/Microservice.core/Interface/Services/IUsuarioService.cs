using Microservice.core.DTOs.Rol.Requests;
using Microservice.core.DTOs.Usuario.Requests;
using Microservice.domain.Wrappers;

namespace Microservice.core.Interface.Services;

public interface IUsuarioService
{
	Task<Response<Object>> AddUsuario(UsuarioDtoRequest usuarioDtoRequest);

    Task<Response<Object>> UpdateUsuario(UsuarioUpdateDtoRequest usuarioUpdateDtoRequest);

    Task<Response<Object>> AddRol(RolDtoRequest rolDtoRequest);

    Task<Response<Object>> UpdateRol(RolDtoRequestUpdate rolDtoRequestUpdate);

}