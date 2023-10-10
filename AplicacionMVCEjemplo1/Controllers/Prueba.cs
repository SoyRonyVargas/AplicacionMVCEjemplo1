using Microsoft.AspNetCore.Mvc;

namespace AplicacionMVCEjemplo1.Controllers
{
    public class Prueba : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
