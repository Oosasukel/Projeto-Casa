using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCasaDeShow.Models
{
    public class Evento : BaseModel
    {
        public Evento(){
            
        }
        public Evento(string clienteId){
            ClienteId = clienteId;
        }
        public string Nome{get;set;}
        public string Data{get;set;}
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Preco{get;set;}
        public int CasaDeShowId{get;set;}
        public CasaDeShow CasaDeShow{get;set;}
        public List<ItemPedido> ItensPedidos{get; set;} = new List<ItemPedido>();
        public string Genero{get;set;}
        public string PathImage{get;set;}
        [Required]
        public string ClienteId{get;set;}
    }
}