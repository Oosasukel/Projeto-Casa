using System.Collections.Generic;
using System.Linq;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public interface ICasaDeShowRepository
    {
        void Add(CasaDeShow casaDeShow);
        IList<CasaDeShow> GetCasas();

        CasaDeShow GetCasaPeloId(int casaId);
        void Delete(int casaId);
        void Update(CasaDeShow casaDeShow);

        int GetQtdEventos(int casaId);
    }
    
    public class CasaDeShowRepository : BaseRepository<CasaDeShow>, ICasaDeShowRepository
    {
        public CasaDeShowRepository(AppContext contexto) : base(contexto)
        {
        }

        public void Add(CasaDeShow casaDeShow)
        {
            dbSet.Add(casaDeShow);
            contexto.SaveChanges();
        }

        public void Delete(int casaId)
        {
            var casa = dbSet.First(casa => casa.Id == casaId);
            dbSet.Remove(casa);
            contexto.SaveChanges();
        }

        public CasaDeShow GetCasaPeloId(int casaId)
        {
            return dbSet.First(casa => casa.Id == casaId);
        }

        public IList<CasaDeShow> GetCasas()
        {
            return dbSet.ToList();
        }

        public int GetQtdEventos(int casaId)
        {
            var qtdEventos = contexto.Eventos.Where(evento => evento.CasaDeShowId == casaId).ToList().Count;
            return qtdEventos;
        }

        public void Update(CasaDeShow casaDeShow)
        {
            var casa = dbSet.First(casa => casa.Id == casaDeShow.Id);
            casa.Nome = casaDeShow.Nome;
            casa.Capacidade = casaDeShow.Capacidade;
            casa.Endereco = casaDeShow.Endereco;
            
            contexto.SaveChanges();
        }
    }
}