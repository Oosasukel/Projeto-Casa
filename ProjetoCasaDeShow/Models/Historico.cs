using System.Collections.Generic;

namespace ProjetoCasaDeShow.Models
{
    public class Historico : BaseModel
    {
        public List<Pedido> Pedidos{get;set;} = new List<Pedido>();
    }
}