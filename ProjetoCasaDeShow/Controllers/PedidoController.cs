using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            ViewBag.pedido = pedido;

            return View();
        }

        public IActionResult AddItemCarrinho(int eventoId){
            dataService.GetPedidoRepository().AddItem(eventoId);

            return RedirectToAction("Carrinho");
        }

        public IActionResult AddHistorico(int id){
            dataService.GetHistoricoRepository().Add(id);
            
            return RedirectToAction("Historico");
        }

        public IActionResult Historico(){
            var historico = dataService.GetHistoricoRepository().GetHistorico();
            ViewBag.itemPedidoRepository = dataService.GetItemPedidoRepository();
            ViewBag.eventoRepository = dataService.GetEventoRepository();

            historico.Pedidos = historico.Pedidos.OrderByDescending(pedido => pedido.Id).ToList();

            return View(historico);
        }
    }
}