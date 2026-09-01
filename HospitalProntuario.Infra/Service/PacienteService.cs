using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Domain.Service.Interface;
using HospitalProntuario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Service
{
    public class PacienteService : IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public async Task<Paciente> GetByIdAsync(int id) =>
            await _pacienteRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Paciente>> GetAllAsync() =>
            await _pacienteRepository.GetAllAsync();

        public async Task AddAsync(Paciente paciente)
        {
            // Exemplo de regra de negócio
            if (string.IsNullOrEmpty(paciente.Nome))
                throw new ArgumentException("Nome do paciente é obrigatório.");

            await _pacienteRepository.AddAsync(paciente);
            await _pacienteRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Paciente paciente)
        {
            _pacienteRepository.Update(paciente);
            await _pacienteRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var paciente = await _pacienteRepository.GetByIdAsync(id);
            if (paciente == null)
                throw new KeyNotFoundException("Paciente não encontrado.");

            _pacienteRepository.Delete(paciente);
            await _pacienteRepository.SaveChangesAsync();
        }
    }

}
