using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Infrastructure
{
    public interface IRepository <T> where T : class
    {
        Task<List<T>> GetAllListAsync();
        Task<T?> FindAsync(int id);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
    }
}
