using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoCasaDeShow.Models;

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
            
            var pedido = dataService.GetPedidoRepository().GetPedido();
            ViewBag.itensPedidos = dataService.GetItemPedidoRepository().GetItensPeloPedidoId(pedido.Id);
            ViewBag.eventoRepository = dataService.GetEventoRepository();

            return View();
        }

        public IActionResult AddItemCarrinho(int eventoId){
            dataService.GetPedidoRepository().AddItem(eventoId);

            return RedirectToAction("Carrinho");
        }
    }
}