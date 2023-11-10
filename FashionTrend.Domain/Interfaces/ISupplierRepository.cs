using FashionTrend.Domain.Entities;

namespace FashionTrend.Domain.Interfaces
{
    public interface ISupplierRepository : IBaseRepository<Supplier>
    {
        Task<Supplier> GetByEmail(string email, CancellationToken cancellationToken);
        Task<Supplier> GetByName(string name, CancellationToken cancellationToken);
        Task<List<Supplier>> GetByMachineType(string machineType, CancellationToken cancellationToken);
        Task<List<Supplier>> GetByMaterialType(string materialType, CancellationToken cancellationToken);
    }
}
