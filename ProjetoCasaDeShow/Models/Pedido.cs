using System.Collections.Generic;

namespace ProjetoCasaDeShow.Models
{
    public class Pedido : BaseModel
    {
        public List<ItemPedido> ItensPedidos{get;set;} = new List<ItemPedido>();
        public Historico Historico{get;set;}
    }
}