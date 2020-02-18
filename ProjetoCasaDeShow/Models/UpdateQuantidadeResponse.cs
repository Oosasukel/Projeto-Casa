using ProjetoCasaDeShow.Models.ViewModels;

namespace ProjetoCasaDeShow.Models
{
    public class UpdateQuantidadeResponse
    {
        public UpdateQuantidadeResponse(ItemPedido itemPedido, CarrinhoViewModel carrinhoViewModel)
        {
            ItemPedido = itemPedido;
            CarrinhoViewModel = carrinhoViewModel;
        }

        public ItemPedido ItemPedido{get;set;}
        public CarrinhoViewModel CarrinhoViewModel{get;set;}
        
    }
}