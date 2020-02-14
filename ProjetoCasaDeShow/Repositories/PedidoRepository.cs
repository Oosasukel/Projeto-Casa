using Microsoft.AspNetCore.Http;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public interface IPedidoRepository
    {
    }

    public class PedidoRepository : BaseRepository<Pedido>, IPedidoRepository
    {
        private readonly IHttpContextAccessor contextAccessor;

        public PedidoRepository(AppContext contexto, IHttpContextAccessor contextAccessor) : base(contexto)
        {
            this.contextAccessor = contextAccessor;
        }

        public int? GetPedidoId(){
            return contextAccessor.HttpContext.Session.GetInt32("PedidoId");
        }

        public void SetPedidoId(int pedidoId){
            contextAccessor.HttpContext.Session.SetInt32("PedidoId", pedidoId);
        }
    }
}