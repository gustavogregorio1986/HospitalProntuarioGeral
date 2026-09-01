using HospitalProntuario.Domain.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalProntuario.Application.Services.Interface
{
    public interface IPagamentoService
    {
        Task<Pagamento> GetByIdAsync(int id);
        Task<IEnumerable<Pagamento>> GetAllAsync();
        Task AddAsync(Pagamento pagamento);
        Task UpdateAsync(Pagamento pagamento);
        Task DeleteAsync(int id);
        Task<IEnumerable<Pagamento>> BuscarPorPacienteIdAsync(int pacienteId);
    }
}
