using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Supplier.CreateSupplier
{
    public sealed record CreateSupplierResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<ESewingMachine> MachineType { get; set; }
        public List<EMaterial> MaterialType { get; set; }
    }
}
