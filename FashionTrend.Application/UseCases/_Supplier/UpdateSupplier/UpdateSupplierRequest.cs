using MediatR;

namespace FashionTrend.Application.UseCases._Supplier.UpdateSupplier
{
    public sealed record UpdateSupplierRequest(
        Guid Id,
        string Email,
        string Name,
        string Password,
        string TipoMaquina,
        string TipoMaterial
        ) : IRequest<UpdateSupplierResponse>;
}
