using FashionTrend.Domain.Entities;

namespace FashionTrend.Domain.Interfaces
{
    public interface ISupplierRepository : IBaseRepository<Supplier>
    {
        Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken);
    }
}
