using ETicaretAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity
    {
        Task<T> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> values);
        T Remove(T entity);
        Task<T> Remove(string id);
        bool RemoveRange(List<T> values);
        T Update(T entity);
        Task<int> SaveAsync();
    }
}
