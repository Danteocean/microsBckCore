using Microservice.core.DTOs.Contrato.Registro;
using Microservice.core.Entities;
using Microservice.domain.Entities;

namespace Microservice.core.Interface.Repositories;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<RegistroVista> RegistroVistaAsync { get; }
	IGenericRepository<RegistroContrato> RegistroContratoaAsync { get; }
	IGenericRepository<AsignacionContratos> AsignacionContratosAsync { get; }

    IGenericRepository<ContratoItemPago> ContratoItemPagoRepositoryAsync { get; }

    Task BeginTransactionAsync();

    Task CommitnAsync();

    Task RollbackAsync();
}