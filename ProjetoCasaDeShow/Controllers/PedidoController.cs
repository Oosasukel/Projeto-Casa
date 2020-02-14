using Microsoft.AspNetCore.Mvc;

namespace ProjetoCasaDeShow.Controllers
{
    public class PedidoController : Controller
    {
        private IDataService dataService;

        public PedidoController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        public IActionResult Carrinho(){
            return View();
        }
    }
}