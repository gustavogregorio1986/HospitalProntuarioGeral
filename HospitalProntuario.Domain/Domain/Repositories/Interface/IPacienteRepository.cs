using HospitalProntuario.Domain.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Interfaces
{
    public interface IPacienteRepository
    {
        Task<Paciente> GetByIdAsync(int id);
        Task<IEnumerable<Paciente>> GetAllAsync();
        Task AddAsync(Paciente paciente);
        void Update(Paciente paciente);
        void Delete(Paciente paciente);
        Task SaveChangesAsync();

        // Método específico
        Task<Paciente> BuscarPorCpfAsync(string cpf);
    }
}
