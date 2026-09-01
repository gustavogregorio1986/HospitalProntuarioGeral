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
    public class MedicoRepository : IMedicoRepository
    {
        private readonly AppDbContext _context;

        public MedicoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Medico> GetByIdAsync(int id) => await _context.Medicos.FindAsync(id);
        public async Task<IEnumerable<Medico>> GetAllAsync() => await _context.Medicos.ToListAsync();
        public async Task AddAsync(Medico medico) => await _context.Medicos.AddAsync(medico);
        public void Update(Medico medico) => _context.Medicos.Update(medico);
        public void Delete(Medico medico) => _context.Medicos.Remove(medico);
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<IEnumerable<Medico>> BuscarPorEspecialidadeAsync(string especialidade) =>
            await _context.Medicos.Where(m => m.Especialidade == especialidade).ToListAsync();
    }
}
