using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoCasaDeShow.Models;
using ProjetoCasaDeShow.Models.ViewModels;

namespace ProjetoCasaDeShow.Controllers
{
    public class PedidoController : Controller
    {
        private IDataService dataService;

        public PedidoController(IDataService dataService)
        {
            this.dataService = dataService;
        }

        [Authorize]
        public IActionResult Carrinho(){
            var pedido = dataService.GetPedidoRepository().GetPedido();
            var itensPedidos = dataService.GetItemPedidoRepository().GetItensPeloPedidoId(pedido.Id);
            
            CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(itensPedidos, pedido.Id);

            return View(carrinhoViewModel);
        }

        [Authorize]
        public IActionResult AddItemCarrinho(int eventoId){
            dataService.GetPedidoRepository().AddItem(eventoId);

            return RedirectToAction("Carrinho");
        }

        [Authorize]
        public IActionResult AddHistorico(int id){
            dataService.GetHistoricoRepository().Add(id);
            
            return RedirectToAction("Historico");
        }

        [Authorize]
        public IActionResult Historico(){
            var historico = dataService.GetHistoricoRepository().GetHistorico();
            ViewBag.itemPedidoRepository = dataService.GetItemPedidoRepository();
            ViewBag.eventoRepository = dataService.GetEventoRepository();

            historico.Pedidos = historico.Pedidos.OrderByDescending(pedido => pedido.Id).ToList();

            return View(historico);
        }

        [HttpPost]
        [Authorize]
        public UpdateQuantidadeResponse updateQuantidade([FromBody]ItemPedido itemPedido){
            var response = dataService.GetPedidoRepository().UpdateQuantidade(itemPedido);
            return response;
        }
    }
}