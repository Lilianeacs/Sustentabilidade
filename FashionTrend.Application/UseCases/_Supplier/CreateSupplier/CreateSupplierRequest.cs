using MediatR;

namespace FashionTrend.Application.UseCases._Supplier.CreateSupplier
{
    public sealed record CreateSupplierRequest(
        string Email,
        string Name,
        string Password,
        string TipoMaquina,
        string TipoMaterial
        ) : IRequest<CreateSupplierResponse>;
}
