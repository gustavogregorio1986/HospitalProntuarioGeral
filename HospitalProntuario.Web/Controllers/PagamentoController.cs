using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class PagamentoController : Controller
    {
        public IActionResult ListarDePagamentos()
        {
            return View();
        }

        public IActionResult CadastroDePagamento()
        {
            return View();
        }
    }
}

