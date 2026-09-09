using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class MedicoController : Controller
    {
        public IActionResult ListarDeMedicos()
        {
            return View();
        }

        public IActionResult CadastroDeMedico()
        {
            return View();
        }
    }
}
