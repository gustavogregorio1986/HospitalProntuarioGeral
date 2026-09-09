using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult RelatorioGeral()
        {
            return View();
        }
    }
}
