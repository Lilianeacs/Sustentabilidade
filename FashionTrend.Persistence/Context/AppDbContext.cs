using FashionTrend.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Service>().Ignore(service => service.Type);
            modelBuilder.Entity<ServiceOrder>().Ignore(ServiceOrder => ServiceOrder.Status);

            modelBuilder.Entity<Product>().Property(e => e.Materials)
                .HasConversion(v => string.Join(",", v.Select(s => s.ToString())),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => (ConstantClasses.EMaterial)Enum.Parse(typeof(ConstantClasses.EMaterial), s)).ToList());

            modelBuilder.Entity<Supplier>().Property(e => e.MachineType)
                .HasConversion(v => string.Join(",", v.Select(s => s.ToString())),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => (ConstantClasses.ESewingMachine)Enum.Parse(typeof(ConstantClasses.ESewingMachine), s)).ToList());

            modelBuilder.Entity<Supplier>().Property(e => e.MaterialType)
               .HasConversion(v => string.Join(",", v.Select(s => s.ToString())),
               v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
               .Select(s => (ConstantClasses.EMaterial)Enum.Parse(typeof(ConstantClasses.EMaterial), s)).ToList());

            modelBuilder.Entity<Service>().Property(e => e.MachineType)
                .HasConversion(v => string.Join(",", v.Select(s => s.ToString())),
                v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => (ConstantClasses.ESewingMachine)Enum.Parse(typeof(ConstantClasses.ESewingMachine), s)).ToList());

            modelBuilder.Entity<Service>().Property(e => e.MaterialType)
               .HasConversion(v => string.Join(",", v.Select(s => s.ToString())),
               v => v.Split(',', StringSplitOptions.RemoveEmptyEntries)
               .Select(s => (ConstantClasses.EMaterial)Enum.Parse(typeof(ConstantClasses.EMaterial), s)).ToList());
        }

        // DB Set ele é a representação de uma tabela
        // que vem do Entities do nosso Domain ao banco de dados
        public DbSet<Supplier> Suppliers{ get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ServiceOrder> ServicesOrder { get; set; }
        public DbSet<ServiceContract> ServicesContract { get; set; }
    }
}

