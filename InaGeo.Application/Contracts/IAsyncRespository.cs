using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InaGeo.Application.Contracts
{
    public interface IAsyncRespository<T> where T: class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IReadOnlyList<T>> ListAllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
