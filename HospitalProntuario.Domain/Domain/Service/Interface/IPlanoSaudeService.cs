using HospitalProntuario.Domain.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalProntuario.Application.Services.Interface
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
