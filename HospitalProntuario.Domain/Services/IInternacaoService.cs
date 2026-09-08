using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Services
{
    public interface IInternacaoService
    {
        Task<Internacao> GetByIdAsync(int id);
        Task<IEnumerable<Internacao>> GetAllAsync();
        Task AddAsync(Internacao internacao);
        Task UpdateAsync(Internacao internacao);
        Task DeleteAsync(int id);
    }
}
