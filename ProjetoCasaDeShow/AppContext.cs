using Microsoft.EntityFrameworkCore;
using ProjetoCasaDeShow.Models;

namespace ProjetoCasaDeShow
{
    public class AppContext : DbContext
    {
        public DbSet<CasaDeShow> CasasDeShow{get;set;}
        public DbSet<Evento> Eventos{get;set;}
        public DbSet<Pedido> Pedidos{get;set;}
        public DbSet<ItemPedido> ItensPedidos{get;set;}

        public AppContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<CasaDeShow>().HasMany(casa => casa.Eventos).WithOne(evento => evento.CasaDeShow);

            modelBuilder.Entity<Evento>().HasOne(evento => evento.CasaDeShow).WithMany(casa => casa.Eventos);
            modelBuilder.Entity<Evento>().HasMany(evento => evento.ItensPedidos).WithOne(itemPedido => itemPedido.Evento);

            modelBuilder.Entity<Pedido>().HasMany(pedido => pedido.ItensPedidos).WithOne(itemPedido => itemPedido.Pedido);
            
            modelBuilder.Entity<ItemPedido>().HasOne(itemPedido => itemPedido.Pedido).WithMany(pedido => pedido.ItensPedidos);
            modelBuilder.Entity<ItemPedido>().HasOne(itemPedido => itemPedido.Evento).WithMany(evento => evento.ItensPedidos);
        }
    }
}