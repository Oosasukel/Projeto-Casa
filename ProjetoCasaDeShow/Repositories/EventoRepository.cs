using System;
using System.IO;
using System.Linq;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public class EventoRepository : BaseRepository<Evento>, IEventoRepository
    {
        public EventoRepository(AppContext contexto) : base(contexto)
        {
        }

        public void Add(Evento b)
        {
            dbSet.Add(b);
        }

        public Evento GetEventoId(int idDaCasa)
        {
            return dbSet.Where(evento => evento.CasaDeShowId == idDaCasa).SingleOrDefault();
        }
    }
}