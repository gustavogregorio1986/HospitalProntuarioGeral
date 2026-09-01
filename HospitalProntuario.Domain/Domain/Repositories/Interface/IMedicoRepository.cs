using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories.Interface
{
    public interface IMedicoRepository
    {
        Task<Medico> GetByIdAsync(int id);
        Task<IEnumerable<Medico>> GetAllAsync();
        Task AddAsync(Medico medico);
        void Update(Medico medico);
        void Delete(Medico medico);
        Task SaveChangesAsync();

        // Método específico
        Task<IEnumerable<Medico>> BuscarPorEspecialidadeAsync(string especialidade);
    }
}
