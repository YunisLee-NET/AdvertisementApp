using Parviz.AdvertisementApp.Common.Enums;
using Parviz.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Parviz.AdvertisementApp.DataAccess.Interface
{
    public interface IRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, OrderByType orderByType);
        Task<List<T>> GetAllAsync<TKey>(Expression<Func<T, TKey>> selector, Expression<Func<T, bool>> filter, OrderByType orderByType = OrderByType.DESC);
        Task<T> Find(object id);
        Task<T> GetByFilter(Expression<Func<T, bool>> expression, bool asNoTracking = false);
        IQueryable GetQuery();
        void Remove(T entity);
        Task AddAsync(T entity);
        void Update(T entity, T unchanged);
    }

     
}
