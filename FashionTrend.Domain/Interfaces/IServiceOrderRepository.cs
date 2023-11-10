using FashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Domain.Interfaces
{
    public interface IServiceOrderRepository : IBaseRepository<ServiceOrder>
    {
        Task<ServiceOrder> GetBySupplierId(Guid idSupplier, CancellationToken cancellationToken);
        Task<ServiceOrder> GetByServiceId(Guid idService, CancellationToken cancellationToken);
        Task<List<ServiceOrder>> GetByStatus(EServiceStatus status, CancellationToken cancellationToken);
    }
}
