using FashionTrend.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FashionTrend.Persistence.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // DB Set ele é a representação de uma tabela
        // que vem do Entities do nosso Domain ao banco de dados
        public DbSet<Supplier> Suppliers{ get; set; }
    }
}
