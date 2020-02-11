using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public interface IEventoRepository
    {
        void Add(Evento b);
        public Evento GetEventoId(int idDaCasa);
    }
}