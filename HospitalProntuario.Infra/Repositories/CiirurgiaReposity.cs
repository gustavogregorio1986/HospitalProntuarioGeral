using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class CiirurgiaReposity : ICirurgiaReposity
    {
        public Task AddAsync(Cirurgia cirurgia)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cirurgia>> BuscarPorMedicoIdAsync(int medicoId)
        {
            throw new NotImplementedException();
        }

        public void Delete(Cirurgia cirurgia)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cirurgia>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Cirurgia> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Cirurgia cirurgia)
        {
            throw new NotImplementedException();
        }
    }
}
