using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        public Task AddAsync(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public Task<Paciente> BuscarPorCpfAsync(string cpf)
        {
            throw new NotImplementedException();
        }

        public void Delete(Paciente paciente)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Paciente>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Paciente> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Paciente paciente)
        {
            throw new NotImplementedException();
        }
    }
}
