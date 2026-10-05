using HospitalProntuario.Domain.Domain.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProntuario.Domain.Services
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> ObterTodosAsync();
        Task<Usuario> ObterPorIdAsync(int id);
        Task AdicionarAsync(Usuario usuario, string senhaPura);
        Task AtualizarAsync(Usuario usuario);
        Task DesativarAsync(int id);
    }
}
