using Microsoft.EntityFrameworkCore;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow
{
    public class AppContext : DbContext
    {
        public DbSet<CasaDeShow> CasasDeShow{get;set;}
        public DbSet<Evento> Eventos{get;set;}
        public AppContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CasaDeShow>().HasMany(casa => casa.Eventos).WithOne(evento => evento.CasaDeShow);
            modelBuilder.Entity<Evento>().HasOne(evento => evento.CasaDeShow).WithMany(casa => casa.Eventos);
        }
    }
}