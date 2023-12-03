using FashionTrend.Domain.Entities;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Domain.Interfaces
{
    public interface IServiceContractRepository
    {
        Task<ServiceContract> GetOrderId(Guid orderId, CancellationToken cancellationToken);
        Task<ServiceContract> GetSupplierId(Guid supplierId, CancellationToken cancellationToken);
        Task<ServiceContract> Status(EContractStatus status, CancellationToken cancellationToken)
    }
}
