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
    public class CirurgiaReposity : ICirurgiaReposity
    {
        private readonly AppDbContext _context;

        public CirurgiaReposity(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Cirurgia> GetByIdAsync(int id) => await _context.Cirurgias.FindAsync(id);
        public async Task<IEnumerable<Cirurgia>> GetAllAsync() => await _context.Cirurgias.ToListAsync();
        public async Task AddAsync(Cirurgia cirurgia) => await _context.Cirurgias.AddAsync(cirurgia);
        public void Update(Cirurgia cirurgia) => _context.Cirurgias.Update(cirurgia);
        public void Delete(Cirurgia cirurgia) => _context.Cirurgias.Remove(cirurgia);
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<IEnumerable<Cirurgia>> BuscarPorMedicoIdAsync(int medicoId) =>
            await _context.Cirurgias.Where(c => c.MedicoId == medicoId).ToListAsync();
    }
}
