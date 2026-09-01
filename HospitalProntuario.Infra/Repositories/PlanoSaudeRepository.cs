using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class PlanoSaudeRepository : IPlanoSaudeRepository
    {
        public Task AddAsync(PlanoSaude planoSaude)
        {
            throw new NotImplementedException();
        }

        public Task<PlanoSaude> BuscarPorNomeAsync(string nome)
        {
            throw new NotImplementedException();
        }

        public void Delete(PlanoSaude planoSaude)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlanoSaude>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PlanoSaude> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(PlanoSaude planoSaude)
        {
            throw new NotImplementedException();
        }
    }
}
