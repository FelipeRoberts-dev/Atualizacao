using Microsoft.AspNetCore.Mvc;
using VendasWeb.Services;
namespace VendasWeb.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;

        public VendedoresController(VendedorService vendedorService)
        {
            _vendedorService = vendedorService;
        }

        public IActionResult Index()
        {
            var vendedores = _vendedorService.FindAll();
            return View(vendedores);
        }
    }
}
