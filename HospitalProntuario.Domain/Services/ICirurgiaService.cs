using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Services
{
    public interface ICirurgiaService
    {
        Task<Cirurgia> GetByIdAsync(int id);
        Task<IEnumerable<Cirurgia>> GetAllAsync();
        Task AddAsync(Cirurgia cirurgia);
        Task UpdateAsync(Cirurgia cirurgia);
        Task DeleteAsync(int id);
    }
}
