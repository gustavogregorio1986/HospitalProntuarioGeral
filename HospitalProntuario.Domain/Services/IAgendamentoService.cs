using HospitalProntuario.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Services
{
    public interface IAgendamentoService
    {
        Task<Agendamento> GetByIdAsync(int id);
        Task<IEnumerable<Agendamento>> GetAllAsync();
        Task AddAsync(Agendamento agendamento);
        Task UpdateAsync(Agendamento agendamento);
        Task DeleteAsync(int id);
    }
}
