using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Services
{
    public interface IPlanoSaudeService
    {
        Task<PlanoSaude> GetByIdAsync(int id);
        Task<IEnumerable<PlanoSaude>> GetAllAsync();
        Task AddAsync(PlanoSaude planoSaude);
        Task UpdateAsync(PlanoSaude planoSaude);
        Task DeleteAsync(int id);
    }
}
