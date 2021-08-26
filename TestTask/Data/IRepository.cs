using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestTask.Data
{
    public interface IRepository<T> : IDisposable
    {
        Task<List<T>> GetAll();
        Task<T> Get(Guid id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(Guid id);
    }
}