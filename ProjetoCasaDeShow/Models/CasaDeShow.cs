using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoCasaDeShow.Models
{
    public class CasaDeShow : BaseModel
    {
        public string Nome{get;set;}
        public int Capacidade{get;set;}
        public string Endereco{get;set;}
        public List<Evento> Eventos{get;set;}
        public string PathImage{get;set;}
    }
}