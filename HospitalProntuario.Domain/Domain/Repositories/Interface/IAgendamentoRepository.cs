using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories.Interface
{
    public interface IAgendamentoRepository
    {
        Task<Agendamento> GetByIdAsync(int id);
        Task<IEnumerable<Agendamento>> GetAllAsync();
        Task AddAsync(Agendamento agendamento);
        void Update(Agendamento agendamento);
        void Delete(Agendamento agendamento);
        Task SaveChangesAsync();

        // Método específico
        Task<IEnumerable<Agendamento>> BuscarPorPacienteIdAsync(int pacienteId);
    }
}
