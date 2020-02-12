using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCasaDeShow.Models
{
    public class Evento : BaseModel
    {
        public string Nome{get;set;}
        public DateTime Data{get;set;}
        public decimal Preco{get;set;}
        public int CasaDeShowId{get;set;}
        public CasaDeShow CasaDeShow{get;set;}
        public string Genero{get;set;}
        public int QtdVendido{get;set;}
    }
}