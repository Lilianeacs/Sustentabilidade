using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Service.CreateService
{
    public sealed record CreateServiceRequest(
        string Name,
        string Email,
        string Password,
        List<ESewingMachine> MachineType,
        List<EMaterial> MaterialType
        ) : IRequest<CreateServiceResponse>;
}
