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
            modelBuilder.Entity<Supplier>().Ignore(supplier => supplier.MaterialType);
            modelBuilder.Entity<Supplier>().Ignore(supplier => supplier.MachineType);
            modelBuilder.Entity<Service>().Ignore(service => service.Material);
            modelBuilder.Entity<Service>().Ignore(service => service.SewingMachine);
            modelBuilder.Entity<Service>().Ignore(service => service.Type);
            modelBuilder.Entity<ServiceOrder>().Ignore(ServiceOrder => ServiceOrder.Status);
        }

        // DB Set ele é a representação de uma tabela
        // que vem do Entities do nosso Domain ao banco de dados
        public DbSet<Supplier> Suppliers{ get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceOrder> ServicesOrder { get; set; }
    }
}
