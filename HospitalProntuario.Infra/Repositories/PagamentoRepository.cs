using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Domain.Repositories.Interface;
using HospitalProntuario.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class PagamentoRepository : IPagamentoRepository
    {
        public Task AddAsync(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pagamento>> BuscarPorPacienteIdAsync(int pacienteId)
        {
            throw new NotImplementedException();
        }

        public void Delete(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pagamento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Pagamento> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Pagamento pagamento)
        {
            throw new NotImplementedException();
        }
    }
}
