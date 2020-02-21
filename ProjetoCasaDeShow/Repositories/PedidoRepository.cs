using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjetoCasaDeShow.Areas.Identity.Data;
using ProjetoCasaDeShow.Models;
using ProjetoCasaDeShow.Models.ViewModels;

namespace ProjetoCasaDeShow.Repositories
{
    public interface IPedidoRepository
    {
        Pedido GetPedido();
        void AddItem(int eventoId);
        UpdateQuantidadeResponse UpdateQuantidade(ItemPedido itemPedido);
    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private IEventoRepository eventoRepository;
        private IItemPedidoRepository itemPedidoRepository;
        private readonly IHttpContextAccessor contextAccessor;
        private UserManager<ProjetoCasaDeShowUser> userManager;

        public PedidoRepository(AppContext contexto, IHttpContextAccessor contextAccessor, IItemPedidoRepository itemPedidoRepository, IEventoRepository eventoRepository, UserManager<ProjetoCasaDeShowUser> userManager) : base(contexto)
        {
            this.eventoRepository = eventoRepository;
            this.contextAccessor = contextAccessor;
            this.itemPedidoRepository = itemPedidoRepository;
            this.userManager = userManager;
        }

        public void AddItem(int eventoId)
        {
            var evento = contexto.Eventos.Where(e => e.Id == eventoId).SingleOrDefault();

            var pedido = GetPedido();

            //Ve se o item já não foi adicionado
            var itemPedido = contexto.ItensPedidos.Where(i => i.PedidoId == pedido.Id && i.EventoId == eventoId).SingleOrDefault();

            //Se não foi adicionado, adiciona
            if(itemPedido == null){
                itemPedido = new ItemPedido(evento, pedido, 1, evento.Preco);
                contexto.ItensPedidos.Add(itemPedido);
                contexto.SaveChanges();
            }
        }

        public Pedido GetPedido()
        {
            var pedidoId = GetPedidoId();
            var pedido = dbSet.Where(pedido => pedido.Id == pedidoId).SingleOrDefault();

            if(pedidoId == null){
                pedido = new Pedido(GetClienteId());
                dbSet.Add(pedido);
                contexto.SaveChanges();
                SetPedidoId(pedido.Id);
            }

            return pedido;
        }

        private int? GetPedidoId(){
            return contextAccessor.HttpContext.Session.GetInt32($"PedidoId_{GetClienteId()}");
        }

        private void SetPedidoId(int pedidoId){
            contextAccessor.HttpContext.Session.SetInt32($"PedidoId_{GetClienteId()}", pedidoId);
        }

        private string GetClienteId(){
            var claimsPrincipal = contextAccessor.HttpContext.User;
            var clienteId = userManager.GetUserId(claimsPrincipal);

            return clienteId;
        }
        

        public UpdateQuantidadeResponse UpdateQuantidade(ItemPedido itemPedido)
        {
            var itemPedidoDb = itemPedidoRepository.GetItemPedido(itemPedido.Id);

            if(itemPedidoDb != null){
                var ingressosDisponiveis = eventoRepository.IngressosDisponiveis(itemPedidoDb.EventoId);
                if(itemPedido.Quantidade > ingressosDisponiveis) itemPedido.Quantidade = ingressosDisponiveis;
                
                if(itemPedido.Quantidade >= 0){
                    itemPedidoDb.Quantidade = itemPedido.Quantidade;
                    contexto.SaveChanges();
                }

                var itens = contexto.ItensPedidos.AsNoTracking().Where(ip => ip.PedidoId == itemPedidoDb.PedidoId).ToList();

                CarrinhoViewModel carrinhoViewModel = new CarrinhoViewModel(itens, itemPedidoDb.PedidoId);

                return new UpdateQuantidadeResponse(carrinhoViewModel);
            }

            throw new ArgumentException("ItemPedido não encontrado");
        }
    }
}