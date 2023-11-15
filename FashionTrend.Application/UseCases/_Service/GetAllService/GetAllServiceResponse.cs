using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Service.GetAllService
{
    public sealed record GetAllServiceResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<ConstantClasses.ESewingMachine> MachineType { get; set; }
        public List<ConstantClasses.EMaterial> MaterialType { get; set; }
    }
}
