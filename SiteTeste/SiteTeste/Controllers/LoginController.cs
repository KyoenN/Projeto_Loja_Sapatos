using Microsoft.AspNetCore.Mvc;

namespace SiteTeste.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
