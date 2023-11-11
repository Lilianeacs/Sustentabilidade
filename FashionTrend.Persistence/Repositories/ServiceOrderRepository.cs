using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using FashionTrend.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace FashionTrend.Persistence.Repositories
{
    public class ServiceOrderRepository : BaseRepository<ServiceOrder>, IServiceOrderRepository
    {
        public ServiceOrderRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<ServiceOrder> GetByServiceId(string idService, CancellationToken cancellationToken)
        {
            return await Context.ServicesOrder.FirstOrDefaultAsync(
                x => x.ServiceID.Equals(idService), cancellationToken);
        }

        public async Task<List<ServiceOrder>> GetByStatus(string status, CancellationToken cancellationToken)
        {
            return await Context.ServicesOrder.Where(
            x => x.Status.Any(s => s.Equals(status))).ToListAsync(cancellationToken);
        }

        public async Task<ServiceOrder> GetBySupplierId(string idSupplier, CancellationToken cancellationToken)
        {
            return await Context.ServicesOrder.FirstOrDefaultAsync(
                x => x.SupplierId.Equals(idSupplier), cancellationToken);
        }
    }
}
