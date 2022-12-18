using Microsoft.AspNetCore.Mvc;

namespace VendasWeb.Controllers
{
    public class VendedoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
