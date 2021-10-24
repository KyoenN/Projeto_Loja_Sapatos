using Microsoft.AspNetCore.Mvc;

namespace SiteTeste.Controllers
{
    public class VendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
