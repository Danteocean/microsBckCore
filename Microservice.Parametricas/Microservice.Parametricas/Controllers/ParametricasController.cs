using Microservice.core.DTOs.Parametricas.Requests;
using Microservice.core.Interface.Services;
using Microservice.domain.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Parametricas.Controllers
{
    [ApiController]
    [Route("Parametricas")]
    public class ParametricasController : ControllerBase
    {
        private readonly IparametricasService _parametricasService;

        public ParametricasController(IparametricasService parametricasService)
        {
            _parametricasService = parametricasService;
        }


        [HttpGet("GetLocalidad")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetLocalidad()
        {
            return Ok(await _parametricasService.GetLocalidad());
        }

        [HttpGet("GetTipoIntervencion")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTipoIntervencion()
        {
            return Ok(await _parametricasService.GetTipoIntervencion());
        }

        [HttpGet("GetUnidades")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetUnidades()
        {
            return Ok(await _parametricasService.GetUnidades());
        }


        [HttpGet("GetItemPago")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetItemPago()
        {
            return Ok(await _parametricasService.GetItemPago());
        }

        [HttpGet("GetTipoSuperficie")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTipoSuperficie()
        {
            return Ok(await _parametricasService.GetTipoSuperficie());
        }

        [HttpPost("AddItemPago")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddItemPago(DescripcionDtoRequest descripcionDtoRequest)
        {
            return Ok(await _parametricasService.AddItemPago(descripcionDtoRequest));
        }

        [HttpPost("AddUnidades")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddUnidades(DescripcionDtoRequest descripcionDtoRequest)
        {
            return Ok(await _parametricasService.AddUnidades(descripcionDtoRequest));
        }

        [HttpPost("AddTipoIntervencion")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddTipoIntervencion(DescripcionDtoRequest descripcionDtoRequest)
        {
            return Ok(await _parametricasService.AddTipoIntervencion(descripcionDtoRequest));
        }

        [HttpPost("AddLocalidad")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddLocalidad(DescripcionDtoRequest descripcionDtoRequest)
        {
            return Ok(await _parametricasService.AddLocalidad(descripcionDtoRequest));
        }

        [HttpPost("AddTipoSuperficie")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> AddTipoSuperficie(DescripcionDtoRequest descripcionDtoRequest)
        {
            return Ok(await _parametricasService.AddTipoSuperficie(descripcionDtoRequest));
        }

        [HttpPut("UpdateItemPago")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateItemPago(ItemPagoDtoRequest itemPagoDtoRequest)
        {
            return Ok(await _parametricasService.UpdateItemPago(itemPagoDtoRequest));
        }

        [HttpPut("UpdateUnidades")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateUnidades(UnidadesDtoRequest unidadesDtoRequest)
        {
            return Ok(await _parametricasService.UpdateUnidades(unidadesDtoRequest));
        }

        [HttpPut("UpdateTipoIntervencion")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateTipoIntervencion(TipoIntervencionDtoRequest tipoIntervencionDtoRequest)
        {
            return Ok(await _parametricasService.UpdateTipoIntervencion(tipoIntervencionDtoRequest));
        }

        [HttpPut("UpdateLocalidad")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateLocalidad(LocalidadDtoRequest localidadDtoRequest)
        {
            return Ok(await _parametricasService.UpdateLocalidad(localidadDtoRequest));
        }

        [HttpPut("UpdateTipoSuperficie")]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(Response<bool>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateTipoSuperficie(TipoSuperficieDtoRequest tipoSuperficieDtoRequest)
        {
            return Ok(await _parametricasService.UpdateTipoSuperficie(tipoSuperficieDtoRequest));
        }
    }
}
