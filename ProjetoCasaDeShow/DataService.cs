using ProjetoCasaDeShow.Models;
using ProjetoCasaDeShow.Repositories;

namespace ProjetoCasaDeShow
{
    public interface IDataService
    {
        IEventoRepository GetEventoRepository();
        ICasaDeShowRepository GetCasaDeShowRepository();
    }

    public class DataService : IDataService
    {
        private IEventoRepository eventoRepository;
        private ICasaDeShowRepository casaDeShowRepository;
        private IPedidoRepository pedidoRepository;

        private AppContext contexto;

        public DataService(IEventoRepository eventoRepository, ICasaDeShowRepository casaDeShowRepository, IPedidoRepository pedidoRepository, AppContext contexto)
        {
            this.eventoRepository = eventoRepository;
            this.casaDeShowRepository = casaDeShowRepository;
            this.pedidoRepository = pedidoRepository;
            this.contexto = contexto;
        }

        public ICasaDeShowRepository GetCasaDeShowRepository()
        {
            return casaDeShowRepository;
        }

        public IEventoRepository GetEventoRepository()
        {
            return eventoRepository;
        }
    }
}