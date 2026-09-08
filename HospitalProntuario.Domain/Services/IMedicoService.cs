using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Services
{
    public interface IMedicoService
    {
        Task<Medico> GetByIdAsync(int id);
        Task<IEnumerable<Medico>> GetAllAsync();
        Task AddAsync(Medico medico);
        Task UpdateAsync(Medico medico);
        Task DeleteAsync(int id);
    }
}
