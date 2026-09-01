using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Infra.Context;
using HospitalProntuario.Infra.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        private readonly AppDbContext _context;

        public AgendamentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Agendamento> GetByIdAsync(int id) => await _context.Agendamentos.FindAsync(id);
        public async Task<IEnumerable<Agendamento>> GetAllAsync() => await _context.Agendamentos.ToListAsync();
        public async Task AddAsync(Agendamento agendamento) => await _context.Agendamentos.AddAsync(agendamento);
        public void Update(Agendamento agendamento) => _context.Agendamentos.Update(agendamento);
        public void Delete(Agendamento agendamento) => _context.Agendamentos.Remove(agendamento);
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<IEnumerable<Agendamento>> BuscarPorPacienteIdAsync(int pacienteId) =>
            await _context.Agendamentos.Where(a => a.PacienteId == pacienteId).ToListAsync();
    }
}
