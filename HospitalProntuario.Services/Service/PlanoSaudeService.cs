using HospitalProntuario.Application.Services.Interface;
using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Domain.Repositories.Interface;
using HospitalProntuario.Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalProntuario.Application.Services
{
    public class PlanoSaudeService : IPlanoSaudeService
    {
        private readonly IPlanoSaudeRepository _planoSaudeRepository;

        public PlanoSaudeService(IPlanoSaudeRepository planoSaudeRepository)
        {
            _planoSaudeRepository = planoSaudeRepository;
        }

        public async Task<PlanoSaude> GetByIdAsync(int id) =>
            await _planoSaudeRepository.GetByIdAsync(id);

        public async Task<IEnumerable<PlanoSaude>> GetAllAsync() =>
            await _planoSaudeRepository.GetAllAsync();

        public async Task AddAsync(PlanoSaude planoSaude)
        {
            // Regra de negócio: nome obrigatório
            if (string.IsNullOrEmpty(planoSaude.Nome))
                throw new ArgumentException("O nome do plano de saúde é obrigatório.");

            await _planoSaudeRepository.AddAsync(planoSaude);
            await _planoSaudeRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(PlanoSaude planoSaude)
        {
            _planoSaudeRepository.Update(planoSaude);
            await _planoSaudeRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var planoSaude = await _planoSaudeRepository.GetByIdAsync(id);
            if (planoSaude == null)
                throw new KeyNotFoundException("Plano de saúde não encontrado.");

            _planoSaudeRepository.Delete(planoSaude);
            await _planoSaudeRepository.SaveChangesAsync();
        }
    }
}
