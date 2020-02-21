using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCasaDeShow.Models
{
    public class Historico : BaseModel
    {
        public Historico(){
            
        }
        public Historico(string clienteId){
            ClienteId = clienteId;
        }
        public List<Pedido> Pedidos{get;set;} = new List<Pedido>();
        [Required]
        public string ClienteId{get;set;}
    }
}