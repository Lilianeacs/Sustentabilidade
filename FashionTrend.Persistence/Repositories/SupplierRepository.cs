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

        public async Task<Supplier> GetByName(string name, CancellationToken cancellationToken)
        {

            return await Context.Suppliers.FirstOrDefaultAsync(
                x => x.Name.Equals(name), cancellationToken);
        }

        public async Task<List<Supplier>> GetByMachineType(string machineType, CancellationToken cancellationToken)
        {
            return await Context.Suppliers.Where(
            x => x.MachineType.Any(s => s.Equals(machineType))).ToListAsync(cancellationToken);
        }

        public async Task<List<Supplier>> GetByMaterialType(string materialType, CancellationToken cancellationToken)
        {
            return await Context.Suppliers.Where(
           x => x.MaterialType.Any(s => s.Equals(materialType))).ToListAsync(cancellationToken);
        }
    }
}
