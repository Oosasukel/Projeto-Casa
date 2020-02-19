using ProjetoCasaDeShow.Models.ViewModels;

namespace ProjetoCasaDeShow.Models
{
    public class UpdateQuantidadeResponse
    {
        public UpdateQuantidadeResponse(CarrinhoViewModel carrinhoViewModel)
        {
            CarrinhoViewModel = carrinhoViewModel;
        }
        public CarrinhoViewModel CarrinhoViewModel{get;set;}
        
    }
}