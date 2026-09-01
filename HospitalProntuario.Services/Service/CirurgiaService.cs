using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Domain.Service.Interface;
using HospitalProntuario.Domain.Interfaces;
using HospitalProntuario.Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Service
{
    public class CirurgiaService : ICirurgiaService
    {
        private readonly ICirurgiaReposity _cirurgiaRepository;

        public CirurgiaService(ICirurgiaReposity cirurgiaRepository)
        {
            _cirurgiaRepository = cirurgiaRepository;
        }

        public async Task<Cirurgia> GetByIdAsync(int id) =>
            await _cirurgiaRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Cirurgia>> GetAllAsync() =>
            await _cirurgiaRepository.GetAllAsync();

        public async Task AddAsync(Cirurgia cirurgia)
        {
            if (cirurgia.Data < DateTime.Now)
                throw new ArgumentException("A data da cirurgia deve ser futura.");

            await _cirurgiaRepository.AddAsync(cirurgia);
            await _cirurgiaRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Cirurgia cirurgia)
        {
            _cirurgiaRepository.Update(cirurgia);
            await _cirurgiaRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var cirurgia = await _cirurgiaRepository.GetByIdAsync(id);
            if (cirurgia == null)
                throw new KeyNotFoundException("Cirurgia não encontrada.");

            _cirurgiaRepository.Delete(cirurgia);
            await _cirurgiaRepository.SaveChangesAsync();
        }
    }


}
