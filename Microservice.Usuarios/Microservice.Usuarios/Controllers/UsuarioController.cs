using Microservice.core.DTOs.Rol.Requests;
using Microservice.core.DTOs.Usuario.Requests;
using Microservice.core.Interface.Services;
using Microservice.domain.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Usuarios.Controllers
{
    [ApiController]
    [Route("Usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("RegistarUsuario")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] UsuarioDtoRequest usuarioDtoRequest)
        {
            return Ok(await _usuarioService.AddUsuario(usuarioDtoRequest));
        }

        [HttpPut("UpdateUsuario")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update([FromBody] UsuarioUpdateDtoRequest usuarioUpdateDtoRequest)
        {
            return Ok(await _usuarioService.AddUsuario(usuarioUpdateDtoRequest));
        }

        [HttpPost("RegistarRol")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostRol([FromBody] RolDtoRequest rolDtoRequest)
        {
            return Ok(await _usuarioService.AddRol(rolDtoRequest));
        }

        [HttpPut("UpdateRol")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateRol([FromBody] RolDtoRequestUpdate rolDtoRequestUpdate)
        {
            return Ok(await _usuarioService.UpdateRol(rolDtoRequestUpdate));
        }
    }
}
