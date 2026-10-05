using HospitalProntuario.Domain.Domain.Usuario;

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
