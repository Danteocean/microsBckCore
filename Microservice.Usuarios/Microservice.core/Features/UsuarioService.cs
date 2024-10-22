using AutoMapper;
using Microservice.core.DTOs.Rol.Requests;
using Microservice.core.DTOs.Usuario.Requests;
using Microservice.core.Interface.Repositories;
using Microservice.core.Interface.Services;
using Microservice.domain.Entities;
using Microservice.domain.Querys.GetRol;
using Microservice.domain.Wrappers;
using Microsoft.Extensions.Configuration;

namespace Microservice.core.Features;

public class UsuarioService : IUsuarioService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IConfiguration _configuration;
    private readonly IMapper _mapper;

    public UsuarioService(IUnitOfWork unitOfWork
            , IConfiguration configuration,
            IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _configuration = configuration;
        _mapper = mapper;
    }

    public async Task<Response<object>> AddRol(RolDtoRequest rolDtoRequest)
    {
        Rol rol = new Rol()
        {
            descripcion = rolDtoRequest.descripcion,
            fechacreacion = DateTime.Now,
            fechamodificacion = DateTime.Now,
            vigente = true
        };

        await _unitOfWork.RolAsync.AddAsync(rol);
        return new Response<Object> { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
    }


    public async Task<Response<object>> UpdateRol(RolDtoRequestUpdate rolDtoRequestUpdate)
    {
        GetRolById getRolById = new GetRolById(_configuration.GetRequiredSection("ConnectionStrings").Value, rolDtoRequestUpdate.rol);
        Rol rol = getRolById.GetRol();

        if (rol.rol == 0)
        {
            return new Response<Object> { Estado = "Error", Respuesta = "Error rol inexistente", Succeeded = false };
        }
        else if (rol == null)
        {
            return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
        }


        rol = new Rol()
        {
            rol = rolDtoRequestUpdate.rol,
            descripcion = rolDtoRequestUpdate.descripcion,
            fechacreacion = rol.fechacreacion,
            fechamodificacion = DateTime.Now,
            vigente = rolDtoRequestUpdate.vigente
        };

        await _unitOfWork.RolAsync.UpdateAsync(rol);
        return new Response<Object> { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
    }

    public async Task<Response<object>> AddUsuario(UsuarioDtoRequest usuarioDtoRequest)
    {
        GetRolById getRolById = new GetRolById(_configuration.GetRequiredSection("ConnectionStrings").Value, usuarioDtoRequest.rol);
        Rol rol = getRolById.GetRol();

        if (rol.rol == 0)
        {
            return new Response<Object> { Estado = "Error", Respuesta = "Error rol inexistente", Succeeded = false };
        }
        else if (rol == null)
        {
            return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
        }

        Usuario usuario = new Usuario()
        {
            nombre = usuarioDtoRequest.nombre,
            appelidos = usuarioDtoRequest.appelidos,
            usuario = usuarioDtoRequest.usuario,
            identificacion = usuarioDtoRequest.identificacion,
            pass = usuarioDtoRequest.pass,
            rol = usuarioDtoRequest.rol
        };


        await _unitOfWork.UsuarioRepositoryAsync.AddAsync(usuario);
        return new Response<Object> { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
    }


    public async Task<Response<object>> UpdateUsuario(UsuarioUpdateDtoRequest usuarioUpdateDtoRequest)
    {
        GetRolById getRolById = new GetRolById(_configuration.GetRequiredSection("ConnectionStrings").Value, usuarioUpdateDtoRequest.rol);
        Rol rol = getRolById.GetRol();

        if (rol.rol == 0)
        {
            return new Response<Object> { Estado = "Error", Respuesta = "Error rol inexistente", Succeeded = false };
        }
        else if (rol == null)
        {
            return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
        }

        Usuario usuario = new Usuario()
        {
            nombre = usuarioUpdateDtoRequest.nombre,
            appelidos = usuarioUpdateDtoRequest.appelidos,
            usuario = usuarioUpdateDtoRequest.usuario,
            identificacion = usuarioUpdateDtoRequest.identificacion,
            pass = usuarioUpdateDtoRequest.pass,
            rol = usuarioUpdateDtoRequest.rol,
            id_usuario = usuarioUpdateDtoRequest.id_usuario
        };
        await _unitOfWork.UsuarioRepositoryAsync.UpdateAsync(usuario);
        return new Response<Object> { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
    }
}
