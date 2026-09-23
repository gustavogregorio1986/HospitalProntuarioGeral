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

        public IActionResult ListarDeRecepcionistas()
        {
            return View();
        }

        public IActionResult CadastroDeUsuario()
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
    }
}
