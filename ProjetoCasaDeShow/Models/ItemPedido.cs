using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ProjetoCasaDeShow.Models
{
    [DataContract]
    public class ItemPedido : BaseModel
    {
        [DataMember]
        public int EventoId{get;set;}
        [DataMember]
        public Evento Evento{get;set;}
        [DataMember]
        public int PedidoId{get;set;}
        [DataMember]
        public Pedido Pedido{get;set;}
        [DataMember]
        public int Quantidade{get;set;}
        [DataMember]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecoUnidade{get;set;}

        public ItemPedido(){

        }

        public ItemPedido(Evento evento, Pedido pedido, int quantidade, decimal precoUnidade)
        {
            Evento = evento;
            Pedido = pedido;
            Quantidade = quantidade;
            PrecoUnidade = precoUnidade;
        }
    }
}