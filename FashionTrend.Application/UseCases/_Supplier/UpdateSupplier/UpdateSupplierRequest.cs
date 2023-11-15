using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Supplier.UpdateSupplier
{
    public sealed record UpdateSupplierRequest(
        Guid Id,
        string Email,
        string Name,
        string Password,
        List<ESewingMachine> MachineType,
        List<EMaterial> MaterialType
        ) : IRequest<UpdateSupplierResponse>;
}
