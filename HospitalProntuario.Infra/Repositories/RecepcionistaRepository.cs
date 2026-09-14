using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HospitalProntuario.Domain.Domain; // Importa a entidade Recepcionista
using HospitalProntuario.Domain.Repositories.Interface; // Importa a interface IRecepcionistaRepository
using HospitalProntuario.Infra.Context; // Importa o AppDbContext

namespace HospitalProntuario.Infra.Repositories
{
    public class RecepcionistaRepository : IRecepcionistaRepository
    {
        private readonly AppDbContext _context;

        public RecepcionistaRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Recepcionista recepcionista)
        {
            await _context.Recepcionistas.AddAsync(recepcionista);
        }

        public async Task<IEnumerable<Recepcionista>> BuscarPorNomeAsync(string nome)
        {
            return await _context.Recepcionistas
                .Where(r => r.Nome.Contains(nome))
                .ToListAsync();
        }

        public async Task<IEnumerable<Recepcionista>> BuscarPorTurnoAsync(string turno)
        {
            return await _context.Recepcionistas
                .Where(r => r.Turno.ToLower() == turno.ToLower())
                .ToListAsync();
        }

        public void Delete(Recepcionista recepcionista)
        {
            _context.Recepcionistas.Remove(recepcionista);
        }

        public async Task<IEnumerable<Recepcionista>> GetAllAsync()
        {
            return await _context.Recepcionistas.ToListAsync();
        }

        public async Task<Recepcionista?> GetByCpfAsync(string cpf)
        {
            return await _context.Recepcionistas
                .FirstOrDefaultAsync(r => r.CPF == cpf);
        }

        public async Task<Recepcionista?> GetByIdAsync(int id)
        {
            return await _context.Recepcionistas.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(Recepcionista recepcionista)
        {
            _context.Recepcionistas.Update(recepcionista);
        }
    }
}