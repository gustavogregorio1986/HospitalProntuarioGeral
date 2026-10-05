using HospitalProntuario.Domain.Domain.Usuario;
using HospitalProntuario.Domain.Repositories.Interface;
using HospitalProntuario.Domain.Services;

namespace HospitalProntuario.Services.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioInterface _usuarioInterface;

        public UsuarioService(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }


        public async Task AdicionarAsync(Usuario usuario, string senhaPura)
        {
            // Valida se o e-mail já existe usando o repositório atualizado
            var existe = await _usuarioInterface.ObterPorEmailAsync(usuario.Email);
            if (existe != null)
            {
                throw new System.Exception("Já existe um utilizador registado com este e-mail.");
            }

            // Faz o hash seguro da senha
            usuario.PasswordHash = BCrypt.Net.BCrypt.HashPassword(senhaPura);

            // Salva na base de dados
            await _usuarioInterface.AdicionarAsync(usuario, senhaPura);
        }



        public async Task AtualizarAsync(Usuario usuario)
        {
            // Delega a atualização para a interface do repositório
            await _usuarioInterface.AtualizarAsync(usuario);
        }

        public async Task DesativarAsync(int id)
        {
            // Primeiro busca o utilizador usando o método da interface
            var usuario = await _usuarioInterface.ObterPorIdAsync(id);
            if (usuario != null)
            {
                // Se encontrar, desativa através da interface
                await _usuarioInterface.DesativarAsync(usuario.Id);
            }
        }

        public async Task<Usuario> ObterPorIdAsync(int id)
        {
            // Busca o utilizador por ID via interface
            return await _usuarioInterface.ObterPorIdAsync(id);
        }

        public async Task<IEnumerable<Usuario>> ObterTodosAsync()
        {
            // Retorna todos os utilizadores via interface
            return await _usuarioInterface.ObterTodosAsync();
        }
    }
}
