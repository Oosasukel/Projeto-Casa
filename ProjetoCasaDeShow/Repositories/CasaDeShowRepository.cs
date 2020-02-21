using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjetoCasaDeShow.Areas.Identity.Data;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow.Repositories
{
    public interface ICasaDeShowRepository
    {
        void Add(CasaDeShow casaDeShow);
        IList<CasaDeShow> GetCasas();
        IList<CasaDeShow> GetCasasCliente();

        CasaDeShow GetCasaPeloId(int casaId);
        void Delete(int casaId);
        void Update(CasaDeShow casaDeShow);

        int GetQtdEventos(int casaId);
    }
    
    public class CasaDeShowRepository : BaseRepository<CasaDeShow>, ICasaDeShowRepository
    {
        private readonly IHttpContextAccessor contextAccessor;
        private UserManager<ProjetoCasaDeShowUser> userManager;
        public CasaDeShowRepository(AppContext contexto,
                                    IHttpContextAccessor contextAccessor,
                                    UserManager<ProjetoCasaDeShowUser> userManager) : base(contexto)
        {
            this.contextAccessor = contextAccessor;
            this.userManager = userManager;
        }

        public void Add(CasaDeShow casaDeShow)
        {
            casaDeShow.ClienteId = GetClienteId();
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
            return dbSet.Include(casa => casa.Eventos).First(casa => casa.Id == casaId);
        }

        public IList<CasaDeShow> GetCasas()
        {
            return dbSet.ToList();
        }

        public IList<CasaDeShow> GetCasasCliente()
        {
            return dbSet.Where(c => c.ClienteId == GetClienteId()).ToList();
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
        
        private string GetClienteId(){
            var claimsPrincipal = contextAccessor.HttpContext.User;
            var clienteId = userManager.GetUserId(claimsPrincipal);

            return clienteId;
        }
    }
}