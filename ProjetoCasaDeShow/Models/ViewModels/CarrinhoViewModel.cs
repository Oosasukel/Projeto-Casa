using System.Collections.Generic;

namespace ProjetoCasaDeShow.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public CarrinhoViewModel(IList<ItemPedido> itens, int pedidoId)
        {
            Itens = itens;
            PedidoId = pedidoId;
        }

        public IList<ItemPedido> Itens{get; private set;}
        public int PedidoId{get; private set;}

        
    }
}