using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class AgendamentoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastroAgendamento()
        {
            return View();
        }
    }
}
