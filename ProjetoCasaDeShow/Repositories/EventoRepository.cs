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
        Evento GetEventoPeloId(int id);
        void Update(Evento evento);
        void Delete(int eventoId);
        int IngressosDisponiveis(int eventoId);
    }
    
    public class EventoRepository : BaseRepository<Evento>, IEventoRepository
    {
        private readonly ICasaDeShowRepository casaDeShowRepository;
        private readonly IHistoricoRepository historicoRepository;
        public EventoRepository(AppContext contexto, ICasaDeShowRepository casaDeShowRepository, IHistoricoRepository historicoRepository) : base(contexto)
        {
            this.casaDeShowRepository = casaDeShowRepository;
            this.historicoRepository = historicoRepository;
        }

        public void Add(Evento evento)
        {
            dbSet.Add(evento);
            contexto.SaveChanges();
        }

        public void Delete(int eventoId)
        {
            var eventoDb = dbSet.First(evento => evento.Id == eventoId);
            contexto.Remove(eventoDb);
            contexto.SaveChanges();
        }

        public Evento GetEventoPeloId(int id)
        {
            var evento = dbSet.First(evento => evento.Id == id);

            return evento;
        }

        public IList<Evento> GetEventos()
        {
            return dbSet.
                ToList();
        }

        public void Update(Evento evento)
        {
            var eventoDb = dbSet.First(eventoDb => eventoDb.Id == evento.Id);
            eventoDb.Nome = evento.Nome;
            eventoDb.Preco = evento.Preco;
            eventoDb.Genero = evento.Genero;
            eventoDb.Data = evento.Data;
            eventoDb.CasaDeShowId = evento.CasaDeShowId;

            contexto.SaveChanges();
        }

        public int IngressosDisponiveis(int eventoId){
            var evento = GetEventoPeloId(eventoId);
            var casa = casaDeShowRepository.GetCasaPeloId(1);

            return casa.Capacidade - historicoRepository.CalculaIngressosVendidosPeloEventoId(eventoId);
        }
    }
}