using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using FashionTrend.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace FashionTrend.Persistence.Repositories
{
    public class SupplierRepository : BaseRepository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(AppDbContext context) : base(context)
        {

        }

        public async Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken)
        {

            return await Context.Suppliers.FirstOrDefaultAsync(
                x => x.Email.Equals(email), cancellationToken);
        }
    }
}
