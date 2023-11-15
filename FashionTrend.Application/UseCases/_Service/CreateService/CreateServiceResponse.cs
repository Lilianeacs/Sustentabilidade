using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Service.CreateService
{
    public sealed record CreateServiceResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<ESewingMachine> MachineType { get; set; }
        public List<EMaterial> MaterialType { get; set; }
    }
}
