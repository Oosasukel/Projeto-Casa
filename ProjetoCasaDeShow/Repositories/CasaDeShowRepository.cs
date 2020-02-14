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

        public CasaDeShow GetCasaPeloId(int casaId)
        {
            return dbSet.First(casa => casa.Id == casaId);
        }

        public IList<CasaDeShow> GetCasas()
        {
            return dbSet.ToList();
        }
    }
}