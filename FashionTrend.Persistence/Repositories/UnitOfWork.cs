using FashionTrend.Domain.Interfaces;
using FashionTrend.Persistence.Context;

namespace FashionTrend.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context)
        {
            _context = context; // representaçção de banco de dados
        }

        public async Task Commit(CancellationToken cancellationToken)
        {
            // esse método ele vai comitar e salvar as alterações no BD
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
