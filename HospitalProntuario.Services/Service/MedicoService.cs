using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Domain.Service.Interface;
using HospitalProntuario.Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Service
{
    public class MedicoService : IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoService(IMedicoRepository medicoRepository)
        {
            _medicoRepository = medicoRepository;
        }

        public async Task<Medico> GetByIdAsync(int id) =>
            await _medicoRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Medico>> GetAllAsync() =>
            await _medicoRepository.GetAllAsync();

        public async Task AddAsync(Medico medico)
        {
            if (string.IsNullOrEmpty(medico.Nome))
                throw new ArgumentException("Nome do médico é obrigatório.");

            await _medicoRepository.AddAsync(medico);
            await _medicoRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Medico medico)
        {
            _medicoRepository.Update(medico);
            await _medicoRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var medico = await _medicoRepository.GetByIdAsync(id);
            if (medico == null)
                throw new KeyNotFoundException("Médico não encontrado.");

            _medicoRepository.Delete(medico);
            await _medicoRepository.SaveChangesAsync();
        }
    }

}
