using Microservice.core.DTOs.Parametricas.Requests;
using Microservice.domain.Entities;
using Microservice.domain.Wrappers;

namespace Microservice.core.Interface.Services;

public interface IparametricasService
{
    Task<Response<Object>> GetUnidades();
    Task<Response<Object>> GetTipoIntervencion();
    Task<Response<Object>> GetLocalidad();
    Task<Response<Object>> GetTipoSuperficie();

    Task<Response<Object>> GetItemPago();

    Task<Response<Object>> AddItemPago(DescripcionDtoRequest descripcionDtoRequest);

    Task<Response<Object>> AddUnidades(DescripcionDtoRequest descripcionDtoRequest);
    Task<Response<Object>> AddTipoIntervencion(DescripcionDtoRequest descripcionDtoRequest);
    Task<Response<Object>> AddLocalidad(DescripcionDtoRequest descripcionDtoRequest);
    Task<Response<Object>> AddTipoSuperficie(DescripcionDtoRequest descripcionDtoRequest);


    Task<Response<Object>> UpdateItemPago(ItemPagoDtoRequest itemPagoDtoRequest);
    Task<Response<Object>> UpdateUnidades(UnidadesDtoRequest unidadesDtoRequest);
    Task<Response<Object>> UpdateTipoIntervencion(TipoIntervencionDtoRequest tipoIntervencionDtoRequest);
    Task<Response<Object>> UpdateLocalidad(LocalidadDtoRequest localidadDtoRequest);
    Task<Response<Object>> UpdateTipoSuperficie(TipoSuperficieDtoRequest tipoSuperficieDtoRequest);
}