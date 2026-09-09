using Microsoft.AspNetCore.Mvc;

namespace HospitalProntuario.Web.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult ListarUsuarios()
        {
            return View();
        }

        public IActionResult ListarDeRecepcionistas()
        {
            return View();
        }

        public IActionResult CadastroDeUsuario()
        {
            return View();
        }

        public IActionResult CadastroDeRecepcionistas()
        {
            return View();
        }
    }
}
