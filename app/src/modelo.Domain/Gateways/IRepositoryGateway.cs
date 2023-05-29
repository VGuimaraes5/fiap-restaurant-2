﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Domain.Gateways
{
    public interface IRepositoryGateway<TEntity, TKey>
    {
        TEntity Get(TKey key);
        Task<TEntity> GetAsync(TKey key);
        IQueryable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> GetByIdAsync(IEnumerable<TKey> Keys);
        Task<TEntity> GetByIdAsync(TKey Keys);
        Task<IEnumerable<TEntity>> IQueryableToIEnumerableEntity(IQueryable<TEntity> query);
        int Insert(TEntity entity);
        Task InsertAsync(TEntity entity);
        int Update(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(TKey key);
    }

}
