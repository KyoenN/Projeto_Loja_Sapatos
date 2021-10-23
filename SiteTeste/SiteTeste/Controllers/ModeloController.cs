using Microsoft.AspNetCore.Mvc;

namespace SiteTeste.Controllers
{
    public class ModeloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
