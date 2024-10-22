using Microservice.domain.Entities;

namespace Microservice.core.Interface.Repositories;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Usuario> UsuarioRepositoryAsync { get; }
    IGenericRepository<Rol> RolAsync { get; }
    //IGenericRepository<AsignacionContratos> AsignacionContratosAsync { get; }

    Task BeginTransactionAsync();

    Task CommitnAsync();

    Task RollbackAsync();
}