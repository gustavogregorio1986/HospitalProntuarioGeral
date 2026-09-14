using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Repositories.Interface;
using HospitalProntuario.Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Service
{
    public class AgendamentoService : IAgendamentoService            
    {
        private readonly IAgendamentoRepository _agendamentoRepository;

        public AgendamentoService(IAgendamentoRepository agendamentoRepository)
        {
            _agendamentoRepository = agendamentoRepository;
        }

        public async Task<Agendamento> GetByIdAsync(int id) =>
            await _agendamentoRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Agendamento>> GetAllAsync() =>
            await _agendamentoRepository.GetAllAsync();

        public async Task AddAsync(Agendamento agendamento)
        {
            if (agendamento.Data < DateTime.Now)
                throw new ArgumentException("A data do agendamento não pode ser no passado.");

            await _agendamentoRepository.AddAsync(agendamento);
            await _agendamentoRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Agendamento agendamento)
        {
            _agendamentoRepository.Update(agendamento);
            await _agendamentoRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var agendamento = await _agendamentoRepository.GetByIdAsync(id);
            if (agendamento == null)
                throw new KeyNotFoundException("Agendamento não encontrado.");

            _agendamentoRepository.Delete(agendamento);
            await _agendamentoRepository.SaveChangesAsync();
        }
    }
}