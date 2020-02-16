using System.Linq;
using Microsoft.AspNetCore.Http;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public interface IPedidoRepository
    {
        int? GetPedidoId();
        void SetPedidoId(int pedidoId);
        Pedido GetPedido();
        void AddItem(int eventoId);
    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAccessor;

        public PedidoRepository(AppContext contexto, IHttpContextAccessor contextAccessor) : base(contexto)
        {
            this.contextAccessor = contextAccessor;
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
                pedido = new Pedido();
                dbSet.Add(pedido);
                contexto.SaveChanges();
                SetPedidoId(pedido.Id);
            }

            return pedido;
        }

        public int? GetPedidoId(){
            return contextAccessor.HttpContext.Session.GetInt32("PedidoId");
        }

        public void SetPedidoId(int pedidoId){
            contextAccessor.HttpContext.Session.SetInt32("PedidoId", pedidoId);
        }

        public void RemovePedidoId(){
            contextAccessor.HttpContext.Session.Remove("PedidoId");
        }
    }
}