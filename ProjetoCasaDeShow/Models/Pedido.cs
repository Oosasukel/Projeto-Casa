using System.Collections.Generic;

namespace ProjetoCasaDeShow.Models
{
    public class Pedido : BaseModel
    {
        public List<ItemPedido> ItensPedidos{get;set;}
    }
}