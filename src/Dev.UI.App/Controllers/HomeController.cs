using Dev.UI.App.Modulos.Produtos.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dev.UI.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPedidoRepositoy _pedidoRepositoy;

        public HomeController(IPedidoRepositoy pedidoRepositoy)
        {
            _pedidoRepositoy = pedidoRepositoy;
        }

        public IActionResult Index()
        {
            var pedido = _pedidoRepositoy.ObterPedido();
            return View();
        }
    }
}
