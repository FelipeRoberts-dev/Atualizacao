using Microsoft.AspNetCore.Mvc;
using VendasWeb.Services;
using VendasWeb.Models;
using VendasWeb.Models.ViewModels;
namespace VendasWeb.Controllers
{
    public class VendedoresController : Controller
    {
        private readonly VendedorService _vendedorService;
        private readonly DepartamentServices _departamentServices;

        public VendedoresController(VendedorService vendedorService, DepartamentServices departamentServices)
        {
            _vendedorService = vendedorService;
            _departamentServices = departamentServices;
        }

        public IActionResult Index()
        {
            var vendedores = _vendedorService.FindAll();
            return View(vendedores);
        }

        public IActionResult Criar()
        {
            var departaments = _departamentServices.FindAll();
            var viewModel = new VendedorFormViewModel { Departaments = departaments };
            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Criar(Vendedor vendedor)
        {
            _vendedorService.Insert(vendedor);
            return RedirectToAction(nameof(Index));
        }
    }
}
