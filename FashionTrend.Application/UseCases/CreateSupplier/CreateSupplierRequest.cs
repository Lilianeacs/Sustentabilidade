using MediatR;

namespace FashionTrend.Application.UseCases.CreateSupplier
{
    public sealed record CreateSupplierRequest ( 
        string Email,
        string Name,
        string Password,
        string TipoMaquina,
        string TipoMaterial
        ) : IRequest<CreateSupplierResponse>;
}
