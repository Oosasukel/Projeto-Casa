using ProjetoCasaDeShow.Models;
using ProjetoCasaDeShow.Repositories;

namespace ProjetoCasaDeShow
{
    public interface IDataService
    {
        void TestaDB();
    }

    public class DataService : IDataService
    {
        private IEventoRepository eventoRepository;
        private ICasaDeShowRepository casaDeShowRepository;

        private AppContext contexto;

        public DataService(IEventoRepository eventoRepository, ICasaDeShowRepository casaDeShowRepository, AppContext contexto)
        {
            this.eventoRepository = eventoRepository;
            this.casaDeShowRepository = casaDeShowRepository;
            this.contexto = contexto;
        }

        public void TestaDB()
        {
            
        }
    }
}