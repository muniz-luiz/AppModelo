using Microsoft.AspNetCore.Mvc;

namespace Dev.UI.App.Modulos.Vendas.Controllers
{
    public class PedidosController : Controller
    {
        [Area("Vendas")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
