using AutoMapper;
using Microservice.core.DTOs.Parametricas.Requests;
using Microservice.core.Interface.Repositories;
using Microservice.core.Interface.Services;
using Microservice.domain.Entities;
using Microservice.domain.Querys.GetListas;
using Microservice.domain.Wrappers;
using Microsoft.Extensions.Configuration;

namespace Microservice.core.Features.Parametrica
{
    public class ParametricaService : IparametricasService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public ParametricaService(IUnitOfWork unitOfWork
            , IConfiguration configuration,
            IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<Response<Object>> GetTipoSuperficie()
        {
            GetTipoSuperficie getTipoSuperficie = new GetTipoSuperficie(_configuration.GetRequiredSection("ConnectionStrings").Value);
            Object result = getTipoSuperficie.Get();

            if (result == null)
            {
                return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
            }
            else
            {
                return new Response<Object>(result) { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
            }
        }

        public async Task<Response<Object>> GetLocalidad()
        {
            GetLocalidad getLocalidad = new GetLocalidad(_configuration.GetRequiredSection("ConnectionStrings").Value);
            Object result = getLocalidad.Get();

            if (result == null)
            {
                return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
            }
            else
            {
                return new Response<Object>(result) { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
            }
        }

        public async Task<Response<Object>> GetTipoIntervencion()
        {
            GetTipoIntervencion getTipoIntervencion = new GetTipoIntervencion(_configuration.GetRequiredSection("ConnectionStrings").Value);
            Object result = getTipoIntervencion.Get();

            if (result == null)
            {
                return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
            }
            else
            {
                return new Response<Object>(result) { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
            }
        }

        public async Task<Response<Object>> GetUnidades()
        {
            GetUnidades getUnidades = new GetUnidades(_configuration.GetRequiredSection("ConnectionStrings").Value);
            Object result = getUnidades.Get();

            if (result == null)
            {
                return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
            }
            else
            {
                return new Response<Object>(result) { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
            }
        }

        public async Task<Response<object>> GetItemPago()
        {
            GetItemPago getItemPago = new GetItemPago(_configuration.GetRequiredSection("ConnectionStrings").Value);
            Object result = getItemPago.Get();

            if (result == null)
            {
                return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
            }
            else
            {
                return new Response<Object>(result) { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
            }
        }

        public async Task<Response<object>> AddItemPago(DescripcionDtoRequest descripcionDtoRequest)
        {
            ItemPago itemPago = new ItemPago()
            {
                descripcion = descripcionDtoRequest.descripcion
            };
            await _unitOfWork.ItemPagoRepositoryAsync.AddAsync(itemPago);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }

        public async Task<Response<object>> AddUnidades(DescripcionDtoRequest descripcionDtoRequest)
        {
            Unidades unidades = new Unidades()
            {
                descripcion = descripcionDtoRequest.descripcion
            };
            await _unitOfWork.UnidadesRepositoryAsync.AddAsync(unidades);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }

        public async Task<Response<object>> AddTipoIntervencion(DescripcionDtoRequest descripcionDtoRequest)
        {
            TipoIntervencion tipoIntervencion = new TipoIntervencion()
            {
                descripcion = descripcionDtoRequest.descripcion
            };
            await _unitOfWork.TipoIntervencionRepositoryAsync.AddAsync(tipoIntervencion);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }

        public async Task<Response<object>> AddLocalidad(DescripcionDtoRequest descripcionDtoRequest)
        {
            Localidad localidad = new Localidad()
            {
                descripcion = descripcionDtoRequest.descripcion
            };
            await _unitOfWork.LocalidadRepositoryAsync.AddAsync(localidad);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }

        public async Task<Response<object>> AddTipoSuperficie(DescripcionDtoRequest descripcionDtoRequest)
        {
            TipoSuperficie tipoSuperficie = new TipoSuperficie()
            {
                descripcion = descripcionDtoRequest.descripcion
            };
            await _unitOfWork.TipoSuperficieRepositoryAsync.AddAsync(tipoSuperficie);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }

        public async Task<Response<object>> UpdateItemPago(ItemPagoDtoRequest itemPagoDtoRequest)
        {
            ItemPago itemPago = new ItemPago()
            {
                id_itempago = itemPagoDtoRequest.id_itempago,
                descripcion = itemPagoDtoRequest.descripcion
            };
            await _unitOfWork.ItemPagoRepositoryAsync.UpdateAsync(itemPago);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }

        public async Task<Response<object>> UpdateUnidades(UnidadesDtoRequest unidadesDtoRequest)
        {
            Unidades unidades = new Unidades()
            {
                id_unidad = unidadesDtoRequest.id_unidad,
                descripcion = unidadesDtoRequest.descripcion
            };
            await _unitOfWork.UnidadesRepositoryAsync.UpdateAsync(unidades);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }

        public async Task<Response<object>> UpdateTipoIntervencion(TipoIntervencionDtoRequest tipoIntervencionDtoRequest)
        {
            TipoIntervencion tipoIntervencion = new TipoIntervencion()
            {
                id_tipointertvencion= tipoIntervencionDtoRequest.id_tipointertvencion,
                descripcion = tipoIntervencionDtoRequest.descripcion
            };

            await _unitOfWork.TipoIntervencionRepositoryAsync.UpdateAsync(tipoIntervencion);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }

        public async Task<Response<object>> UpdateLocalidad(LocalidadDtoRequest localidadDtoRequest)
        {
            Localidad localidad = new Localidad()
            {
                id_localidad= localidadDtoRequest.id_localidad,
                descripcion = localidadDtoRequest.descripcion
            };
            await _unitOfWork.LocalidadRepositoryAsync.UpdateAsync(localidad);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }

        public async Task<Response<object>> UpdateTipoSuperficie(TipoSuperficieDtoRequest tipoSuperficieDtoRequest)
        {
            TipoSuperficie tipoSuperficie = new TipoSuperficie()
            {
                id_tiposuperficie= tipoSuperficieDtoRequest.id_tiposuperficie,
                descripcion = tipoSuperficieDtoRequest.descripcion
            };

            await _unitOfWork.TipoSuperficieRepositoryAsync.UpdateAsync(tipoSuperficie);

            return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
        }
    }
}