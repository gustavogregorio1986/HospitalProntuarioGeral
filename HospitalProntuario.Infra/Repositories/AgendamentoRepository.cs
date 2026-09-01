using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Infra.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {
        public Task AddAsync(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Agendamento>> BuscarPorPacienteIdAsync(int pacienteId)
        {
            throw new NotImplementedException();
        }

        public void Delete(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Agendamento>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Agendamento> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(Agendamento agendamento)
        {
            throw new NotImplementedException();
        }
    }
}
