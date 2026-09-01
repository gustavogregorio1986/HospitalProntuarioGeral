using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Domain.Repositories.Interface;
using HospitalProntuario.Application.Services.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalProntuario.Application.Services
{
    public class PagamentoService : IPagamentoService
    {
        private readonly IPagamentoRepository _pagamentoRepository;

        public PagamentoService(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        public async Task<Pagamento> GetByIdAsync(int id) =>
            await _pagamentoRepository.GetByIdAsync(id);

        public async Task<IEnumerable<Pagamento>> GetAllAsync() =>
            await _pagamentoRepository.GetAllAsync();

        public async Task AddAsync(Pagamento pagamento)
        {
            // Regra de negócio: valor deve ser positivo
            if (pagamento.Valor <= 0)
                throw new ArgumentException("O valor do pagamento deve ser maior que zero.");

            await _pagamentoRepository.AddAsync(pagamento);
            await _pagamentoRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Pagamento pagamento)
        {
            _pagamentoRepository.Update(pagamento);
            await _pagamentoRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var pagamento = await _pagamentoRepository.GetByIdAsync(id);
            if (pagamento == null)
                throw new KeyNotFoundException("Pagamento não encontrado.");

            _pagamentoRepository.Delete(pagamento);
            await _pagamentoRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<Pagamento>> BuscarPorPacienteIdAsync(int pacienteId) =>
            await _pagamentoRepository.BuscarPorPacienteIdAsync(pacienteId);
    }
}
