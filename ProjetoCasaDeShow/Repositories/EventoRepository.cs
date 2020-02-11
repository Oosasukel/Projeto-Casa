using System;
using System.IO;
using System.Linq;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public interface IEventoRepository
    {
        void Add(Evento evento);
    }
    
    public class EventoRepository : BaseRepository<Evento>, IEventoRepository
    {
        public EventoRepository(AppContext contexto) : base(contexto)
        {
        }

        public void Add(Evento evento)
        {
            dbSet.Add(evento);
            contexto.SaveChanges();
        }
    }
}