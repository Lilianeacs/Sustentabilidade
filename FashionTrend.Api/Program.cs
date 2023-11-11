using FashionTrend.Api.Extensions;
using FashionTrend.Application.Services;
using FashionTrend.Persistence.Repositories;

namespace FashionTrend.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.ConfigurePersistenceApp(builder.Configuration);
            builder.Services.ConfigureApplicationApp();
            builder.Services.ConfigureCorsPolicy();

            
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();
            BD.BD.CreateDataBase(app);
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors();
            app.MapControllers();
            app.Run();
        }
    }
}