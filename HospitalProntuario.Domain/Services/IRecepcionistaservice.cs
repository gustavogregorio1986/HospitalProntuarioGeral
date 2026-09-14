using HospitalProntuario.Domain.Domain; // Onde está sua classe Recepcionista
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Services.Interface
{
    public interface IRecepcionistaService
    {
        Task<Recepcionista?> GetByIdAsync(int id);
        Task<IEnumerable<Recepcionista>> GetAllAsync();
        Task<Recepcionista> AddAsync(Recepcionista recepcionista);
        Task UpdateAsync(Recepcionista recepcionista);
        Task DeleteAsync(int id);

        // Métodos de negócio específicos
        Task<Recepcionista?> GetByCpfAsync(string cpf);
        Task<IEnumerable<Recepcionista>> BuscarPorTurnoAsync(string turno);
        Task<IEnumerable<Recepcionista>> BuscarPorNomeAsync(string nome);
    }
}