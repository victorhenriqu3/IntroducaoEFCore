using Microsoft.EntityFrameworkCore;
using OrderingSystem.Domain;
using Microsoft.Extensions.Logging;
namespace OrderingSystem.Data
{
    public class ApplicationContext : DbContext
    {
        private static readonly ILoggerFactory _logger = LoggerFactory.Create(
            (p => p.AddConsole())
        );
        public DbSet<Pedido> Pedidos { set; get; }
        public DbSet<Cliente> Clientes { set; get; }
        public DbSet<Produto> Produtos { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(_logger)
                .EnableSensitiveDataLogging()
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=OrderingSystem");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }
}
