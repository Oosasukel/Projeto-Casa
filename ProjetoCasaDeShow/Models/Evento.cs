using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoCasaDeShow.Models
{
    public class Evento : BaseModel
    {
        public string Nome{get;set;}
        public string Data{get;set;}
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        public decimal Preco{get;set;}
        public int CasaDeShowId{get;set;}
        public CasaDeShow CasaDeShow{get;set;}
        public List<ItemPedido> ItensPedidos{get; set;}
        public string Genero{get;set;}
    }
}