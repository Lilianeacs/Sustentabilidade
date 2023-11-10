using FashionTrend.Domain.Interfaces;
using FashionTrend.Persistence.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using FashionTrend.Persistence.Repositories;

namespace FashionTrend.Persistence.Repositories
{
    public static class ServiceExtensions
    {
        // usar para configurar a camada de persistencia no EF core
        public static void ConfigurePersistenceApp(
            this IServiceCollection services, IConfiguration configuration)
        {
            // recuperar a string de conexão da camada de presentation /api/
            var connectionString = configuration.GetConnectionString("Sqlite");

            // Definir o provedor de banco de dados
            services.AddDbContext<AppDbContext>(
                opt => opt.UseSqlite(connectionString));

            // Toda a construção de escopo da nossa aplicação ficará aqui
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<IServiceRepository, ServiceRepository>();
            services.AddScoped<IServiceOrderRepository, ServiceOrderRepository>();

        }
    }
}


