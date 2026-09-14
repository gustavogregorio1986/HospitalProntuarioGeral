using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HospitalProntuario.Domain.Domain; // Onde está a entidade Recepcionista
using HospitalProntuario.Domain.Repositories.Interface; // Onde está a IRecepcionistaRepository
using HospitalProntuario.Domain.Services.Interface; // Onde está a IRecepcionistaService

namespace HospitalProntuario.Domain.Services
{
    public class RecepcionistaService : IRecepcionistaService
    {
        private readonly IRecepcionistaRepository _recepcionistaRepository;

        public RecepcionistaService(IRecepcionistaRepository recepcionistaRepository)
        {
            _recepcionistaRepository = recepcionistaRepository;
        }

        public async Task<Recepcionista?> GetByIdAsync(int id)
        {
            return await _recepcionistaRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Recepcionista>> GetAllAsync()
        {
            return await _recepcionistaRepository.GetAllAsync();
        }

        public async Task<Recepcionista> AddAsync(Recepcionista recepcionista)
        {
            // Validação de regra de negócio: Evitar duplicidade de CPF
            var existente = await _recepcionistaRepository.GetByCpfAsync(recepcionista.CPF);
            if (existente != null)
            {
                throw new InvalidOperationException("Já existe uma recepcionista cadastrada com este CPF.");
            }

            await _recepcionistaRepository.AddAsync(recepcionista);
            await _recepcionistaRepository.SaveChangesAsync();

            return recepcionista;
        }

        public async Task UpdateAsync(Recepcionista recepcionista)
        {
            _recepcionistaRepository.Update(recepcionista);
            await _recepcionistaRepository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var recepcionista = await _recepcionistaRepository.GetByIdAsync(id);
            if (recepcionista == null)
            {
                throw new KeyNotFoundException("Recepcionista não encontrada.");
            }

            _recepcionistaRepository.Delete(recepcionista);
            await _recepcionistaRepository.SaveChangesAsync();
        }

        public async Task<Recepcionista?> GetByCpfAsync(string cpf)
        {
            return await _recepcionistaRepository.GetByCpfAsync(cpf);
        }

        public async Task<IEnumerable<Recepcionista>> BuscarPorTurnoAsync(string turno)
        {
            return await _recepcionistaRepository.BuscarPorTurnoAsync(turno);
        }

        public async Task<IEnumerable<Recepcionista>> BuscarPorNomeAsync(string nome)
        {
            return await _recepcionistaRepository.BuscarPorNomeAsync(nome);
        }
    }
}