using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class InternacaoController : Controller
    {
        public IActionResult ListarDeInternacoes()
        {
            return View();
        }

        public IActionResult CadastroDeInternacao()
        {
            return View();
        }
    }
}
