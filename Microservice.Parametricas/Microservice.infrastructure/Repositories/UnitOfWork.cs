using Microservice.core.Interface.Repositories;
using Microservice.domain.Entities;
using Microservice.infrastructure.Repositories.RepositoryAsync;
using Microservice.infrastructure.Setting;
using Microsoft.EntityFrameworkCore.Storage;

namespace Microservice.infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly MicroServiceContext _context;
    private IDbContextTransaction? _transaction;

    public UnitOfWork(MicroServiceContext context) => _context = context;

    public IGenericRepository<ItemPago> ItemPagoRepositoryAsync => new ItemPagoRepositoryAsync(_context);

	public IGenericRepository<Localidad> LocalidadRepositoryAsync => new LocalidadRepositoryAsync(_context);

	public IGenericRepository<TipoIntervencion> TipoIntervencionRepositoryAsync => new TipoIntervencionRepositoryAsync(_context);

    public IGenericRepository<TipoSuperficie> TipoSuperficieRepositoryAsync => new TipoSuperficieRepositoryAsync(_context);

    public IGenericRepository<Unidades> UnidadesRepositoryAsync => new UnidadesRepositoryAsync(_context);

    public async Task BeginTransactionAsync()
    {
        _transaction = await _context.Database.BeginTransactionAsync().ConfigureAwait(false);
    }

    public async Task CommitnAsync()
    {
        try
        {
            await BeginTransactionAsync();
            await _context.SaveChangesAsync();
            await _transaction!.CommitAsync();
        }
        catch
        {
            await RollbackAsync();
            throw;
        }
        finally
        {
            _transaction?.Dispose();
            Dispose();
        }
    }

    private bool disposed = false;

    private void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public Task RollbackAsync()
    {
        _transaction?.Rollback();
        _transaction?.Dispose();
        return Task.CompletedTask;
    }
}