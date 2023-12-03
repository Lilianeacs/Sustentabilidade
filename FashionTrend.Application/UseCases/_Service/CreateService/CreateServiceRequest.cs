using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Service.CreateService
{
    public sealed record CreateServiceRequest(
        string Description,
        EServiceType ServiceType,
        string Password,
        List<ESewingMachine> MachineType,
        List<EMaterial> MaterialType
        ) : IRequest<CreateServiceResponse>;
}
