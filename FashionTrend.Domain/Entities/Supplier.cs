using static FashionTrend.Domain.Entities.ConstantClasses;
namespace FashionTrend.Domain.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<ESewingMachine> MachineType { get; set; }
        public List<EMaterial> MaterialType { get; set; }
    }
}
