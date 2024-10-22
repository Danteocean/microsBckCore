﻿using Microservice.core.Interface.Repositories;
using Microservice.domain.Exceptions;
using Microservice.infrastructure.Extensions;
using Microservice.infrastructure.Setting;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Microservice.infrastructure.Repositories.RepositoryAsync;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly MicroServiceContext _dbContext;
    protected readonly DbSet<TEntity> _entities;
    protected readonly DbSet<DataTable> _tables;

    public GenericRepository(MicroServiceContext dbContext)
    {
        _dbContext = dbContext ?? throw new InfrastructureException(nameof(dbContext), $"El parametro dbContext no puede ser null");
        _entities = _dbContext.Set<TEntity>();
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        using (var transaction =_dbContext.Database.BeginTransaction())
        {
            try
            {
                ValidateNullEntity<TEntity>.IsNullEntity(entity);

                _entities.Add(entity);
                await _dbContext.SaveChangesAsync().ConfigureAwait(false);
                transaction.Commit();
                return entity;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new InfrastructureException(nameof(UpdateAsync),ex.Message);
            }
        }
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        using (var transaction = _dbContext.Database.BeginTransaction())
        {
            try
            {
                ValidateNullEntity<TEntity>.IsNullEntity(entity);

                _entities.Update(entity);
                await _dbContext.SaveChangesAsync().ConfigureAwait(false);
                transaction.Commit();
                return entity;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new InfrastructureException(nameof(UpdateAsync), ex.Message);
            }
        }
    }
}