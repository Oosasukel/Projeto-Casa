using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjetoCasaDeShow.Areas.Identity.Data;
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
        private UserManager<ProjetoCasaDeShowUser> userManager;
        public HistoricoRepository(AppContext contexto, IHttpContextAccessor contextAccessor, UserManager<ProjetoCasaDeShowUser> userManager) : base(contexto)
        {
            this.contextAccessor = contextAccessor;
            this.userManager = userManager;
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
            contextAccessor.HttpContext.Session.Remove($"PedidoId_{GetClienteId()}");
        }

        public Historico GetHistorico()
        {
            var historico = dbSet.
                                Include(historico => historico.Pedidos).Where(historico => historico.ClienteId == GetClienteId()).SingleOrDefault();

            if(historico == null){
                historico = new Historico(GetClienteId());
                dbSet.Add(historico);
                contexto.SaveChanges();
            }

            return historico;
        }

        private string GetClienteId(){
            var claimsPrincipal = contextAccessor.HttpContext.User;
            var clienteId = userManager.GetUserId(claimsPrincipal);

            return clienteId;
        }
    }
}