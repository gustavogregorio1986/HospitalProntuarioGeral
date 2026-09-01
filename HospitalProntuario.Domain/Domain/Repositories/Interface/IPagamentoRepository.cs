using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Domain.Repositories.Interface
{
    public interface IPagamentoRepository
    {
        Task<Pagamento> GetByIdAsync(int id);
        Task<IEnumerable<Pagamento>> GetAllAsync();
        Task AddAsync(Pagamento pagamento);
        void Update(Pagamento pagamento);
        void Delete(Pagamento pagamento);
        Task SaveChangesAsync();

        // Método específico
        Task<IEnumerable<Pagamento>> BuscarPorPacienteIdAsync(int pacienteId);
    }
}
