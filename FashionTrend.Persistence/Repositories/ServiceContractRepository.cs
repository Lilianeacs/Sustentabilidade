using FashionTrend.Domain.Entities;
using FashionTrend.Domain.Interfaces;
using FashionTrend.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Persistence.Repositories
{
    public class ServiceContractRepository : BaseRepository<ServiceContract>, IServiceContractRepository
    {
        public ServiceContractRepository(AppDbContext context) : base(context)
        {

        }
        
        public async Task<ServiceContract> GetOrderId(Guid orderId, CancellationToken cancellationToken)
        {
            return await Context.ServicesContract.Where(x => x.OrderId.Equals(orderId)).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<ServiceContract> GetSupplierId(Guid supplierId, CancellationToken cancellationToken)
        {
            return await Context.ServicesContract.Where(x => x.SupplierId.Equals(supplierId)).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<ServiceContract> Status(EContractStatus status, CancellationToken cancellationToken)
        {
            return await Context.ServicesContract.Where(x => x.Status.Equals(status)).FirstOrDefaultAsync(cancellationToken);
        }
    }
}
