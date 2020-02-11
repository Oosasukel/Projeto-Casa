using System.Collections.Generic;

namespace ProjetoCasaDeShow.Models
{
    public class CasaDeShow : BaseModel
    {
        public string Nome{get;set;}
        public int Capacidade{get;set;}
        public string Endereco{get;set;}
        public int EventosId{get;set;}
        public List<Evento> Eventos{get;set;}
    }
}