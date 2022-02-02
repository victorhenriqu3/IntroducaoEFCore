using Microsoft.EntityFrameworkCore;
using OrderingSystem.Domain;
namespace OrderingSystem.Data
{
  public class ApplicationContext : DbContext
    {
        DbSet<Pedido> Pedidos { set; get; }
        DbSet<Cliente> Clientes { set; get; }
        DbSet<Produto> Produtos { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OrderingSystem");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}