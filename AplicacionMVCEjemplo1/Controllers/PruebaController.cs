using Microsoft.AspNetCore.Mvc;

namespace AplicacionMVCEjemplo1.Controllers
{
    public class PruebaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
