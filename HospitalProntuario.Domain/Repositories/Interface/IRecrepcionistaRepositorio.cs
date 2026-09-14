using HospitalProntuario.Domain.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Repositories.Interface
{
    public interface IRecepcionistaRepository
    {
        Task<Recepcionista?> GetByIdAsync(int id);
        Task<IEnumerable<Recepcionista>> GetAllAsync();
        Task AddAsync(Recepcionista recepcionista);
        void Update(Recepcionista recepcionista);
        void Delete(Recepcionista recepcionista);
        Task SaveChangesAsync();

        // Métodos específicos
        Task<Recepcionista?> GetByCpfAsync(string cpf);
        Task<IEnumerable<Recepcionista>> BuscarPorTurnoAsync(string turno);
        Task<IEnumerable<Recepcionista>> BuscarPorNomeAsync(string nome);
    }
}