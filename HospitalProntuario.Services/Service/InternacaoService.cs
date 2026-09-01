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
    public class InternacaoService : IInternacaoService
    {
        private readonly IInternacaoRepository _internacaoRepository;

        public InternacaoService(IInternacaoRepository internacaoRepository)
        {
            _internacaoRepository = internacaoRepository;
        }

        public async Task<Internacao> GetByIdAsync(int id) =>
            await _internacaoRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Internacao>> GetAllAsync() =>
            await _internacaoRepository.GetAllAsync();

        public async Task AddAsync(Internacao internacao)
        {
            if (internacao.DataEntrada > internacao.DataSaida)
                throw new ArgumentException("Data de entrada não pode ser maior que a de saída.");

            await _internacaoRepository.AddAsync(internacao);
            await _internacaoRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Internacao internacao)
        {
            _internacaoRepository.Update(internacao);
            await _internacaoRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var internacao = await _internacaoRepository.GetByIdAsync(id);
            if (internacao == null)
                throw new KeyNotFoundException("Internação não encontrada.");

            _internacaoRepository.Delete(internacao);
            await _internacaoRepository.SaveChangesAsync();
        }
    }

}
