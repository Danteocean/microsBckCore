using Microservice.domain.Entities;

namespace Microservice.core.Interface.Repositories;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<ItemPago> ItemPagoRepositoryAsync { get; }
	IGenericRepository<Localidad> LocalidadRepositoryAsync { get; }
	IGenericRepository<TipoIntervencion> TipoIntervencionRepositoryAsync { get; }

    IGenericRepository<TipoSuperficie> TipoSuperficieRepositoryAsync { get; }

    IGenericRepository<Unidades> UnidadesRepositoryAsync { get; }

    Task BeginTransactionAsync();

    Task CommitnAsync();

    Task RollbackAsync();
}