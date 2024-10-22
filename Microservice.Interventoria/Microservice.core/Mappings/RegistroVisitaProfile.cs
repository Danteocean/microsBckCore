using AutoMapper;
using Microservice.core.DTOs.Contrato.Registro;
using Microservice.core.DTOs.RegistroVisita.Requests;
using Microservice.core.Entities;
using Microservice.domain.Entities;

namespace Microservice.core.Mappings;

public class RegistroVisitaProfile:Profile
{
    public RegistroVisitaProfile()
    {
        CreateMap<RegistroVisitaDtoRequest, RegistroVista>();
		CreateMap<RegistroContratoDto, RegistroContrato>();
	}
}