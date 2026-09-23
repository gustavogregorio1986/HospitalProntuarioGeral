using HospitalProntuario.Domain.Domain;
using HospitalProntuario.Domain.Services.Interface;
using HospitalProntuario.Services.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IRecepcionistaService _recepcionistaService;

        public UsuarioController(IRecepcionistaService recepcionistaService)
        {
            _recepcionistaService = recepcionistaService;
        }

        [HttpGet]
        public async Task<IActionResult> ListarDeRecepcionistas(int pagina = 1)
        {
            int pageSize = 10; // Quantidade de registos por página

            // Chama o método paginado do serviço que criámos (desestrutura a tupla)
            var (recepcionistas, totalPages) = await _recepcionistaService.GetPagedAsync(pagina, pageSize);

            // Passa os dados de controlo para a View através do ViewBag
            ViewBag.CurrentPage = pagina;
            ViewBag.TotalPages = totalPages;

            // Retorna a lista paginada para a View
            return View(recepcionistas);
        }

        public IActionResult CadastroDeUsuario()
        {
            return View();
        }

        public IActionResult ListarUsuarios()
        {
            return View();
        }

        public IActionResult CadastroDeRecepcionistas()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CadastroRecepcionista(RecepcionistaRequestDto model)
        {
            if (!ModelState.IsValid)
            {
                // Se houver falha na validação, retorna para a mesma view com os dados
                return View(model);
            }

            var recepcionista = new Recepcionista
            {
                Nome = model.Nome,
                CPF = model.Cpf,
                Email = model.Email,
                Turno = model.Turno
            };

            await _recepcionistaService.AddAsync(recepcionista);

            TempData["MensagemSucesso"] = "Recepcionista cadastrada com sucesso!";

            // Redireciona para a listagem após salvar com sucesso
            return RedirectToAction("CadastroDeRecepcionistas", "Usuario");
        }

        [HttpGet("buscar")]
        public async Task<IActionResult> BuscarPorCpf(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
            {
                ModelState.AddModelError(string.Empty, "O CPF deve ser informado.");
                return View("Index"); // Ou a view correspondente
            }

            // Chama o método assíncrono que você criou
            var recepcionista = await _recepcionistaService.GetByCpfAsync(cpf);

            if (recepcionista == null)
            {
                TempData["MensagemErro"] = "Recepcionista não encontrado.";
                return View("Index");
            }

            // Retorna a View passando o objeto encontrado
            return View("Detalhes", recepcionista);
        }


    }
}
