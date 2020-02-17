using ProjetoCasaDeShow.Models;
using ProjetoCasaDeShow.Repositories;

namespace ProjetoCasaDeShow
{
    public interface IDataService
    {
        IEventoRepository GetEventoRepository();
        ICasaDeShowRepository GetCasaDeShowRepository();
        IItemPedidoRepository GetItemPedidoRepository();
        IPedidoRepository GetPedidoRepository();
        IHistoricoRepository GetHistoricoRepository();

        AppContext GetContexto();
    }

    public class DataService : IDataService
    {
        private IEventoRepository eventoRepository;
        private ICasaDeShowRepository casaDeShowRepository;
        private IPedidoRepository pedidoRepository;
        private IItemPedidoRepository itemPedidoRepository;
        private IHistoricoRepository historicoRepository;

        private AppContext contexto;

        public DataService(IEventoRepository eventoRepository, ICasaDeShowRepository casaDeShowRepository, IPedidoRepository pedidoRepository, IItemPedidoRepository itemPedidoRepository, IHistoricoRepository historicoRepository, AppContext contexto)
        {
            this.eventoRepository = eventoRepository;
            this.casaDeShowRepository = casaDeShowRepository;
            this.pedidoRepository = pedidoRepository;
            this.itemPedidoRepository = itemPedidoRepository;
            this.historicoRepository = historicoRepository;

            this.contexto = contexto;
        }

        public ICasaDeShowRepository GetCasaDeShowRepository()
        {
            return casaDeShowRepository;
        }

        public AppContext GetContexto()
        {
            return contexto;
        }

        public IEventoRepository GetEventoRepository()
        {
            return eventoRepository;
        }

        public IHistoricoRepository GetHistoricoRepository()
        {
            return historicoRepository;
        }

        public IItemPedidoRepository GetItemPedidoRepository()
        {
            return itemPedidoRepository;
        }

        public IPedidoRepository GetPedidoRepository()
        {
            return pedidoRepository;
        }
    }
}