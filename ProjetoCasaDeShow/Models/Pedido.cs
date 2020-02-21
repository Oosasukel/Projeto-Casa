using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCasaDeShow.Models
{
    public class Pedido : BaseModel
    {
        public Pedido(){
            
        }
        public Pedido(string clienteId){
            ClienteId = clienteId;
        }
        public List<ItemPedido> ItensPedidos{get;set;} = new List<ItemPedido>();
        public Historico Historico{get;set;}
        [Required]
        public string ClienteId{get;set;}
    }
}