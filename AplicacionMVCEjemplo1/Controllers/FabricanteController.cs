using AplicacionMVCEjemplo1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AplicacionMVCEjemplo1.Controllers
{
    public class FabricanteController : Controller
	{
		private readonly Productos24BmContext dbContext;

		public FabricanteController(Productos24BmContext db)
		{
			dbContext = db;
		}
		public async Task<IActionResult> Index()
        {
			
			List<Fabricante> fabricantes = await this.dbContext
				.Fabricantes.ToListAsync();

            return View(fabricantes);
        }
    }
}
