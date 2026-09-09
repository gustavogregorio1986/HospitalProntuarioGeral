using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class CirurgiaController : Controller
    {
        public IActionResult ListarDeCirurgias()
        {
            return View();
        }

        public IActionResult CadastroDeCirurgia()
        {
            return View();
        }
    }
}
