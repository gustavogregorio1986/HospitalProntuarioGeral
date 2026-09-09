using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class FinanceiroController : Controller
    {
        public IActionResult PagamentoFinanceiro()
        {
            return View();
        }
    }
}
