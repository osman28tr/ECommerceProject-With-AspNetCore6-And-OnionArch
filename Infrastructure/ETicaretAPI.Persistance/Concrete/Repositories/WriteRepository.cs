using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities.Common;
using ETicaretAPI.Persistance.Concrete.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Concrete.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ETicaretAPIContext _context;

        public WriteRepository(ETicaretAPIContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public async Task<T> AddAsync(T entity)
        {
            EntityEntry<T> entityEntry = await Table.AddAsync(entity);
            return entityEntry.Entity;
        }

        public async Task<bool> AddRangeAsync(List<T> values)
        {
            await Table.AddRangeAsync(values);
            return true;
        }

        public T Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.Entity;
        }
        public bool RemoveRange(List<T> values)
        {
            Table.RemoveRange(values);
            return true;
        }
        public async Task<T> Remove(string id)
        {
            T model = await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
            return Remove(model);
        }
        public T Update(T entity)
        {
            EntityEntry<T> entityEntry = Table.Update(entity);
            return entityEntry.Entity;
        }
        public async Task<int> SaveAsync() => await _context.SaveChangesAsync();     
    }
}
