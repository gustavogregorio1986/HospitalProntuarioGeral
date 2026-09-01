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
    public class InternacaoRepository : IInternacaoRepository
    {
        private readonly AppDbContext _context;

        public InternacaoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Internacao> GetByIdAsync(int id) => await _context.Internacoes.FindAsync(id);
        public async Task<IEnumerable<Internacao>> GetAllAsync() => await _context.Internacoes.ToListAsync();
        public async Task AddAsync(Internacao internacao) => await _context.Internacoes.AddAsync(internacao);
        public void Update(Internacao internacao) => _context.Internacoes.Update(internacao);
        public void Delete(Internacao internacao) => _context.Internacoes.Remove(internacao);
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<IEnumerable<Internacao>> BuscarPorPacienteIdAsync(int pacienteId) =>
            await _context.Internacoes.Where(i => i.PacienteId == pacienteId).ToListAsync();
    }
}
