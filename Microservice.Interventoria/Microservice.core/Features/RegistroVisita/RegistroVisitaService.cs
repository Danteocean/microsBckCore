using AutoMapper;
using Microservice.core.DTOs.Contrato.Registro;
using Microservice.core.DTOs.Contrato.Response;
using Microservice.core.DTOs.ContratoItemPago.Requests;
using Microservice.core.DTOs.RegistroVisita.Requests;
using Microservice.core.Entities;
using Microservice.core.Interface.Repositories;
using Microservice.core.Interface.Services;
using Microservice.domain.Entities;
using Microservice.domain.Querys.GetInContrato;
using Microservice.domain.Wrappers;
using Microsoft.Extensions.Configuration;

namespace Microservice.core.Features.RegistroVisita
{
    public class RegistroVisitaService : IinterventoriaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public RegistroVisitaService(IUnitOfWork unitOfWork
            , IConfiguration configuration,
            IMapper mapper
            )
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<Response<Object>> GetContrato(int id_contrato)
        {
            GetInContratoByIdContrato getInContratoBy = new GetInContratoByIdContrato(_configuration.GetRequiredSection("ConnectionStrings").Value, id_contrato);
            ContratoDtoResponse contratoDtoResponse = new ContratoDtoResponse();
            Object result = getInContratoBy.Get();

            if (result == null)
            {
                return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
            }
            else
            {
                return new Response<Object>(result) { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
            }
        }

        public async Task<Response<object>> PostGuardarRegistroVisita(RegistroVisitaDtoRequest registroVisitaDtoRequest)
        {
            RegistroVista registroVista = _mapper.Map<RegistroVista>(source: registroVisitaDtoRequest);
            await _unitOfWork.RegistroVistaAsync.AddAsync(registroVista);
            if (registroVista.id_registrovisita != 0)
            {
                return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
            }
            else
            {
                return new Response<object> { Estado = "Error", Respuesta = "Error al guardar", Succeeded = false };
            }
        }

        public async Task<Response<object>> PostGuardarContrato(RegistroContratoDto registroContrato)
        {
            //RegistroContrato registrarContrato = _mapper.Map<RegistroContrato>(source: registroContrato);

            RegistroContrato _registrarContrato = new RegistroContrato
            {
                direccion = registroContrato.Direccion,
                fecha_fin = registroContrato.Fecha_Fin,
                fecha_inicio = registroContrato.Fecha_Inicio,
                id_localidad = registroContrato.Id_Localidad,
                id_tipointertvencion = registroContrato.Id_TipoIntervencion,
                id_tiposuperficie = registroContrato.Id_TipoSuperficie,
                nombre = registroContrato.Nombre
            };

            await _unitOfWork.RegistroContratoaAsync.AddAsync(_registrarContrato);
            if (_registrarContrato.id_contrato != 0)
            {
                AsignacionContratos asignacionContratos = new AsignacionContratos
                {
                    id_contrato = _registrarContrato.id_contrato,
                    id_usuario = registroContrato.IngenieroAsignado
                };

                await _unitOfWork.AsignacionContratosAsync.AddAsync(asignacionContratos);
                if (asignacionContratos.id_asignacion != 0)
                {
                    return new Response<object> { Estado = "Ok", Respuesta = "Registrado correctamente", Succeeded = true };
                }
                else
                {
                    return new Response<object> { Estado = "Error", Respuesta = "Error al guardar", Succeeded = false };
                }

            }
            else
            {
                return new Response<object> { Estado = "Error", Respuesta = "Error al guardar", Succeeded = false };
            }
        }
        public async Task<Response<Object>> GetContratosByUser(int user)
        {
            GetListContratosByUsuario getInContratoByUser = new GetListContratosByUsuario(_configuration.GetRequiredSection("ConnectionStrings").Value, user);

            Object result = getInContratoByUser.Get();

            if (result == null)
            {
                return new Response<Object> { Estado = "Error", Respuesta = "Error al conectarse a la bd", Succeeded = false };
            }
            else
            {
                return new Response<Object>(result) { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
            }
        }

        public async Task<Response<object>> PostContratoItemPago(ContratoItemPagoDtoRequest contratoItemPagoDtoRequest)
        {
            ContratoItemPago contratoItemPago = new ContratoItemPago
            {
                id_contrato = contratoItemPagoDtoRequest.id_contrato,
                id_itempago = contratoItemPagoDtoRequest.id_itempago
            };

            await _unitOfWork.ContratoItemPagoRepositoryAsync.AddAsync(contratoItemPago);
            return new Response<Object> { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };

        }

        public async Task<Response<object>> UpdateContratoItemPago(ContratoItemPagoUpdateDtoRequest contratoItemPagoUpdateDto)
        {
            ContratoItemPago contratoItemPago = new ContratoItemPago
            {
                idconasgi = contratoItemPagoUpdateDto.idconasgi,
                id_contrato = contratoItemPagoUpdateDto.id_contrato,
                id_itempago = contratoItemPagoUpdateDto.id_itempago
            };
            await _unitOfWork.ContratoItemPagoRepositoryAsync.UpdateAsync(contratoItemPago);
            return new Response<Object> { Estado = "Ok", Respuesta = "Registro encontrado", Succeeded = true };
        }
    }
}