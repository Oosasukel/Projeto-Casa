using System.Linq;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public class CasaDeShowRepository : BaseRepository<CasaDeShow>, ICasaDeShowRepository
    {
        public CasaDeShowRepository(AppContext contexto) : base(contexto)
        {
        }

        public void Add(CasaDeShow a)
        {
            dbSet.Add(a);
            contexto.SaveChanges();
        }
    }
}