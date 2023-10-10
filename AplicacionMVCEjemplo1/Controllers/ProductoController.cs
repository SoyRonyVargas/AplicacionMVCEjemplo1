using AplicacionMVCEjemplo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AplicacionMVCEjemplo1.Controllers
{
    public class ProductoController : Controller
    {

        private readonly Productos24BmContext dbContext;

        public ProductoController(Productos24BmContext db)
        {
            dbContext = db;
        }

        public async Task<IActionResult> Index()
        {

            List<Producto> productos = await this.dbContext.Productos.ToListAsync();

            return View(productos);
        }

        public IActionResult Prueba()
        {
            return View();
        }
    }
}
