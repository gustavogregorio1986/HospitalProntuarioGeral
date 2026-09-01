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
    public class PlanoSaudeRepository : IPlanoSaudeRepository
    {
        private readonly AppDbContext _context;

        public PlanoSaudeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<PlanoSaude> GetByIdAsync(int id) => await _context.PlanosSaude.FindAsync(id);
        public async Task<IEnumerable<PlanoSaude>> GetAllAsync() => await _context.PlanosSaude.ToListAsync();
        public async Task AddAsync(PlanoSaude planoSaude) => await _context.PlanosSaude.AddAsync(planoSaude);
        public void Update(PlanoSaude planoSaude) => _context.PlanosSaude.Update(planoSaude);
        public void Delete(PlanoSaude planoSaude) => _context.PlanosSaude.Remove(planoSaude);
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<PlanoSaude> BuscarPorNomeAsync(string nome) =>
            await _context.PlanosSaude.FirstOrDefaultAsync(p => p.Nome == nome);
    }
}
