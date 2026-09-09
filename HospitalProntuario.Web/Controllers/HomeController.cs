using HospitalProntuario.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HospitalProntuario.Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
