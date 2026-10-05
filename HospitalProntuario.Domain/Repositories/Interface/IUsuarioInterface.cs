using HospitalProntuario.Domain.Domain.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Repositories.Interface
{
    public interface IUsuarioInterface
    {
        Task<IEnumerable<Usuario>> ObterTodosAsync();
        Task<Usuario> ObterPorIdAsync(int id);
        Task AdicionarAsync(Usuario usuario, string senhaPura);
        Task AtualizarAsync(Usuario usuario);
        Task DesativarAsync(int id);

        Task<Usuario> ObterPorEmailAsync(string email);
    }
}
