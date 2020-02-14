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
        private readonly ICasaDeShowRepository casaDeShowRepository;
        private readonly IItemPedidoRepository itemPedidoRepository;
        public EventoRepository(AppContext contexto, ICasaDeShowRepository casaDeShowRepository, IItemPedidoRepository itemPedidoRepository) : base(contexto)
        {
            this.casaDeShowRepository = casaDeShowRepository;
            this.itemPedidoRepository = itemPedidoRepository;
        }

        public void Add(Evento evento)
        {
            dbSet.Add(evento);
            contexto.SaveChanges();
        }

        public IList<Evento> GetEventos()
        {
            return dbSet.
                ToList();
        }
    }
}