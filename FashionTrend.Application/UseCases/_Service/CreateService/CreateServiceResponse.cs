using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Service.CreateService
{
    public sealed record CreateServiceResponse
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public EServiceType ServiceType{ get; set; }
        public List<ESewingMachine> MachineType { get; set; }
        public List<EMaterial> MaterialType { get; set; }
    }
}
