using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {
        public Task AddAsync(Medico medico)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Medico>> BuscarPorEspecialidadeAsync(string especialidade)
        {
            throw new NotImplementedException();
        }

        public void Delete(Medico medico)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Medico>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Medico> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Medico medico)
        {
            throw new NotImplementedException();
        }
    }
}
