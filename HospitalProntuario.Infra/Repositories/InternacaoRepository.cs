using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class InternacaoRepository : IInternacaoRepository
    {
        public Task AddAsync(Internacao internacao)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Internacao>> BuscarPorPacienteIdAsync(int pacienteId)
        {
            throw new NotImplementedException();
        }

        public void Delete(Internacao internacao)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Internacao>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Internacao> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Internacao internacao)
        {
            throw new NotImplementedException();
        }
    }
}
