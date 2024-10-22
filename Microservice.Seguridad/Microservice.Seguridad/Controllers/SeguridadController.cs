using Microservice.core.DTOs.Login;
using Microservice.core.Interface.Services;
using Microservice.domain.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Seguridad.Controllers;

[Route("Seguridad")]
[ApiController]
public class SeguridadController : ControllerBase
{
    private readonly ILoginService _loginService;

    public SeguridadController(ILoginService loginService)
    {
        _loginService = loginService;
    }

    [HttpPost("login")]
    [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
    [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> Get([FromBody] Login login)
    {

        return Ok(await _loginService.GetLogin(login));
    }
}