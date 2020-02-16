using System.Collections.Generic;
using System.Linq;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public interface IItemPedidoRepository
    {
        IList<ItemPedido> GetItensPedidos();
        IList<ItemPedido> GetItensPedidosPeloEventoId(int eventoId);
        int SomaQuantidadePedidosPeloEventoId(int eventoId);
        IList<ItemPedido> GetItensPeloPedidoId(int pedidoId);
    }
    public class ItemPedidoRepository : BaseRepository<ItemPedido>, IItemPedidoRepository
    {
        public ItemPedidoRepository(AppContext contexto) : base(contexto)
        {
        }

        public IList<ItemPedido> GetItensPedidosPeloEventoId(int eventoid){
            return dbSet.Where(itemPedido => itemPedido.EventoId == eventoid).ToList();;
        }

        public IList<ItemPedido> GetItensPedidos()
        {
            return dbSet.ToList();
        }

        public int SomaQuantidadePedidosPeloEventoId(int eventoId)
        {
            return dbSet.Where(pedido => pedido.EventoId == eventoId).Sum(pedido => pedido.Quantidade);
        }

        public IList<ItemPedido> GetItensPeloPedidoId(int pedidoId)
        {
            var itensPedidos = dbSet.Where(item => item.PedidoId == pedidoId).ToList();
            return itensPedidos;
        }
    }
}