using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class PlanoDeSaudeController : Controller
    {
        public IActionResult ListarDePlanos()
        {
            return View();
        }

        public IActionResult CadastroDePlano()
        {
            return View();
        }
    }
}
