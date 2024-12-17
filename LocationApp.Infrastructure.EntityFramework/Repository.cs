using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Infrastructure.EntityFramework
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbSet<T> _dbSet;
        private readonly LocationAppDbContext _dbContext;
        public Repository(LocationAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<T>> GetAllListAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> FindAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);

        }

        public async Task InsertAsync(T entity)
        {
            await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }

}
