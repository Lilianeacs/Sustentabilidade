using FashionTrend.Domain.Entities;

namespace FashionTrend.Domain.Interfaces
{
    public interface IServiceRepository : IBaseRepository<Service>
    {
        Task<List<Service>> GetByType(string type, CancellationToken cancellationToken);
        Task<List<Service>> GetByMachine(string machine, CancellationToken cancellationToken);
        Task<List<Service>> GetByMaterial(string material, CancellationToken cancellationToken);
    }
}
