using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    namespace HospitalProntuario.Domain.Interfaces
    {
        public interface IGenericRepository<T> where T : class
        {
            Task<T> GetByIdAsync(int id);
            Task<IEnumerable<T>> GetAllAsync();
            Task AddAsync(T entity);
            void Update(T entity);
            void Delete(T entity);
            Task SaveChangesAsync();
        }
    }

}
