using HospitalProntuario.Domain.Domain.Usuario;
using HospitalProntuario.Domain.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Infra.Repositories
{
    public class UsuarioRepository : IUsuarioInterface
    {
        public Task AdicionarAsync(Usuario usuario, string senhaPura)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarAsync(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public Task DesativarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> ObterPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}
