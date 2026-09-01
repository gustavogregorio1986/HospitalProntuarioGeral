using HospitalProntuario.Domain.Domain;
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
    public class PacienteRepository : IPacienteRepository
    {
        private readonly AppDbContext _context;

        public PacienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Paciente> GetByIdAsync(int id) => await _context.Pacientes.FindAsync(id);
        public async Task<IEnumerable<Paciente>> GetAllAsync() => await _context.Pacientes.ToListAsync();
        public async Task AddAsync(Paciente paciente) => await _context.Pacientes.AddAsync(paciente);
        public void Update(Paciente paciente) => _context.Pacientes.Update(paciente);
        public void Delete(Paciente paciente) => _context.Pacientes.Remove(paciente);
        public async Task SaveChangesAsync() => await _context.SaveChangesAsync();

        public async Task<Paciente> BuscarPorCpfAsync(string cpf) =>
            await _context.Pacientes.FirstOrDefaultAsync(p => p.CPF == cpf);
    }
}
