using Microservice.core.DTOs.Contrato.Registro;
using Microservice.core.DTOs.ContratoItemPago.Requests;
using Microservice.core.DTOs.RegistroVisita.Requests;
using Microservice.core.Interface.Services;
using Microservice.domain.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Interventoria.Controllers
{
    [ApiController]
    [Route("Interventoria")]
    public class InterventoriaController : ControllerBase
    {
        private readonly IinterventoriaService _interventoriaService;

        public InterventoriaController(IinterventoriaService interventoriaService)
        {
            _interventoriaService = interventoriaService;
        }

        [HttpPost("PostGuardarVisita")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] RegistroVisitaDtoRequest registroVisitaDtoRequest)
        {
            return Ok(await _interventoriaService.PostGuardarRegistroVisita(registroVisitaDtoRequest));
        }

        [HttpGet("GetDatosContrato")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get(int id_contrato)
        {
            return Ok(await _interventoriaService.GetContrato(id_contrato));
        }

        [HttpPost("RegistrarContrato")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] RegistroContratoDto registroContrato)
        {
            return Ok(await _interventoriaService.PostGuardarContrato(registroContrato));
        }


        [HttpGet("GetContratos")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetContratosByUser(int user)
        {
            return Ok(await _interventoriaService.GetContratosByUser(user));
        }

        [HttpPost("RegistrarContratoItemPago")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Post([FromBody] ContratoItemPagoDtoRequest contratoItemPagoDtoRequest)
        {
            return Ok(await _interventoriaService.PostContratoItemPago(contratoItemPagoDtoRequest));
        }

        [HttpPut("UpdateContratoItemPago")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Update([FromBody] ContratoItemPagoUpdateDtoRequest contratoItemPagoUpdateDto)
        {
            return Ok(await _interventoriaService.UpdateContratoItemPago(contratoItemPagoUpdateDto));
        }
    }
}