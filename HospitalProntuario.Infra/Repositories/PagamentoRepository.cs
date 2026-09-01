using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Domain.Repositories.Interface;
using HospitalProntuario.Domain.Interfaces;
using HospitalProntuario.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        private readonly AppDbContext _context;

        public PagamentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Pagamento> GetByIdAsync(int id) => await _context.Pagamentos.FindAsync(id);
        public async Task<IEnumerable<Pagamento>> GetAllAsync() => await _context.Pagamentos.ToListAsync();
        public async Task AddAsync(Pagamento pagamento) => await _context.Pagamentos.AddAsync(pagamento);
        public void Update(Pagamento pagamento) => _context.Pagamentos.Update(pagamento);
        public void Delete(Pagamento pagamento) => _context.Pagamentos.Remove(pagamento);
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<IEnumerable<Pagamento>> BuscarPorPacienteIdAsync(int pacienteId) =>
            await _context.Pagamentos.Where(p => p.PacienteId == pacienteId).ToListAsync();
    }
}
