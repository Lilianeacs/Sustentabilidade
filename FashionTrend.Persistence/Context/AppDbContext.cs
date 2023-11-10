using FashionTrend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FashionTrend.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Supplier>().Ignore(supplier => supplier.Materials);
            modelBuilder.Entity<Supplier>().Ignore(supplier => supplier.MachinesType);
            modelBuilder.Entity<Service>().Ignore(service => service.Materials);
            modelBuilder.Entity<Service>().Ignore(service => service.SewingMachines);
            modelBuilder.Entity<Service>().Ignore(service => service.Type);
        }

        // DB Set ele é a representação de uma tabela
        // que vem do Entities do nosso Domain ao banco de dados
        public DbSet<Supplier> Suppliers{ get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceOrder> ServicesOrder { get; set; }
    }
}
