using Microservice.core.DTOs.Contrato.Registro;
using Microservice.core.DTOs.ContratoItemPago.Requests;
using Microservice.core.DTOs.RegistroVisita.Requests;
using Microservice.domain.Wrappers;

namespace Microservice.core.Interface.Services;

public interface IinterventoriaService
{
    Task<Response<Object>> PostGuardarRegistroVisita(RegistroVisitaDtoRequest registroVisitaDtoRequest);
	Task<Response<Object>> PostGuardarContrato(RegistroContratoDto registroContrato);
	Task<Response<Object>> GetContrato(int id_contrato);
	Task<Response<Object>> GetContratosByUser(int user);

    Task<Response<Object>> PostContratoItemPago(ContratoItemPagoDtoRequest contratoItemPagoDtoRequest);

    Task<Response<Object>> UpdateContratoItemPago(ContratoItemPagoUpdateDtoRequest contratoItemPagoUpdateDto);

}