using FashionTrend.Domain.Entities;

namespace FashionTrend.Domain.Interfaces
{
    public interface IServiceOrderRepository : IBaseRepository<ServiceOrder>
    {
        Task<ServiceOrder> GetBySupplierId(string idSupplier, CancellationToken cancellationToken);
        Task<ServiceOrder> GetByServiceId(string idService, CancellationToken cancellationToken);
        Task<List<ServiceOrder>> GetByStatus(string status, CancellationToken cancellationToken);
    }
}
