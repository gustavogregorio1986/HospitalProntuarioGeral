using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories.Interface
{
    public interface IInternacaoRepository
    {
        Task<Internacao> GetByIdAsync(int id);
        Task<IEnumerable<Internacao>> GetAllAsync();
        Task AddAsync(Internacao internacao);
        void Update(Internacao internacao);
        void Delete(Internacao internacao);
        Task SaveChangesAsync();

        // Método específico
        Task<IEnumerable<Internacao>> BuscarPorPacienteIdAsync(int pacienteId);
    }
}
