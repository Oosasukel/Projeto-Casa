using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCasaDeShow.Models
{
    public class ItemPedido : BaseModel
    {
        public int EventoId{get;set;}
        public Evento Evento{get;set;}
        public int PedidoId{get;set;}
        public Pedido Pedido{get;set;}
        public int Quantidade{get;set;}
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