using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Service.UpdateService
{
    public sealed record UpdateServiceRequest(
        Guid Id,
        string Email,
        string Name,
        string Password,
        List<ESewingMachine> MachineType,
        List<EMaterial> MaterialType
        ) : IRequest<UpdateServiceResponse>;
}
