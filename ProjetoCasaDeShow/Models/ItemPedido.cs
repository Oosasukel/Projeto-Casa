namespace ProjetoCasaDeShow.Models
{
    public class ItemPedido : BaseModel
    {
        public int EventoId{get;set;}
        public Evento Evento{get;set;}
        public int PedidoId{get;set;}
        public Pedido Pedido{get;set;}
        public int Quantidade{get;set;}
        public decimal PrecoUnidade{get;set;}
    }
}