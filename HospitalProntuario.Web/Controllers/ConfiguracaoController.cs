using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class ConfiguracaoController : Controller
    {
        public IActionResult ConfiguracaoPadrao()
        {
            return View();
        }
    }
}
