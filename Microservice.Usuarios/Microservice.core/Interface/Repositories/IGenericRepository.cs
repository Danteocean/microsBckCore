namespace Microservice.core.Interface.Repositories;

public interface IGenericRepository<TEntity> where TEntity : class
{

    Task<TEntity> AddAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);
}