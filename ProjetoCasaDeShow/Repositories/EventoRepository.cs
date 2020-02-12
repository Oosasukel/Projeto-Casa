using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public interface IEventoRepository
    {
        void Add(Evento evento);

        IList<Evento> GetEventos();
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

        public IList<Evento> GetEventos()
        {
            return dbSet.Include(evento => evento.CasaDeShow).ToList();
        }
    }
}