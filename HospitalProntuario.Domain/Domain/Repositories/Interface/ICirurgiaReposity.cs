using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories.Interface
{
    public interface ICirurgiaReposity
    {
        Task<Cirurgia> GetByIdAsync(int id);
        Task<IEnumerable<Cirurgia>> GetAllAsync();
        Task AddAsync(Cirurgia cirurgia);
        void Update(Cirurgia cirurgia);
        void Delete(Cirurgia cirurgia);
        Task SaveChangesAsync();

        // Método específico
        Task<IEnumerable<Cirurgia>> BuscarPorMedicoIdAsync(int medicoId);
    }
}
