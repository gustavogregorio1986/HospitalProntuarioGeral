using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories.Interface
{
    public interface IPlanoSaudeRepository
    {
        Task<PlanoSaude> GetByIdAsync(int id);
        Task<IEnumerable<PlanoSaude>> GetAllAsync();
        Task AddAsync(PlanoSaude planoSaude);
        void Update(PlanoSaude planoSaude);
        void Delete(PlanoSaude planoSaude);
        Task SaveChangesAsync();

        // Método específico
        Task<PlanoSaude> BuscarPorNomeAsync(string nome);
    }
}
