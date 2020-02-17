using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public interface IHistoricoRepository
    {
        void Add(int pedidoId);
        Historico GetHistorico();
        int CalculaIngressosVendidosPeloEventoId(int eventoId);
    }
    public class HistoricoRepository : BaseRepository<Historico>, IHistoricoRepository
    {
        private readonly IHttpContextAccessor contextAccessor;
        public HistoricoRepository(AppContext contexto, IHttpContextAccessor contextAccessor) : base(contexto)
        {
            this.contextAccessor = contextAccessor;
        }

        public int CalculaIngressosVendidosPeloEventoId(int eventoId){
            var qtdVendida = contexto.ItensPedidos.
                                Include(item => item.Pedido).
                                    ThenInclude(pedido => pedido.Historico).
                                Where(item => item.Pedido.Historico != null && item.EventoId == eventoId).
                                Sum(item => item.Quantidade);

            return qtdVendida;
        }

        public void Add(int pedidoId)
        {
            var pedido = contexto.Pedidos.Include(pedido => pedido.ItensPedidos).Where(pedido => pedido.Id == pedidoId).SingleOrDefault();

            if(pedido != null && pedido.ItensPedidos.Count > 0){
                var historico = GetHistorico();
                historico.Pedidos.Add(pedido);
                contexto.SaveChanges();
                RemovePedidoId();
            }
        }

        private void RemovePedidoId(){
            contextAccessor.HttpContext.Session.Remove("PedidoId");
        }

        public Historico GetHistorico()
        {
            var historico = dbSet.
                                Include(historico => historico.Pedidos).Where(historico => historico.Id == 1).SingleOrDefault();

            if(historico == null){
                historico = new Historico();
                historico.Id = 1;
                dbSet.Add(historico);
                contexto.SaveChanges();
            }

            return historico;
        }
    }
}