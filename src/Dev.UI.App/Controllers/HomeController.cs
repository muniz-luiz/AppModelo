using Microsoft.AspNetCore.Mvc;

namespace Dev.UI.App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
