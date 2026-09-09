using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class PacienteController : Controller
    {
       

        public IActionResult ListarDePacientes()
        {
            return View();
        }

        public IActionResult CadastroDePaciente()
        {
            return View();
        }
    }
}
