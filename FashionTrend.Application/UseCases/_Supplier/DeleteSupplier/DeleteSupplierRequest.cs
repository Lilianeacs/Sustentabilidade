using MediatR;

namespace FashionTrend.Application.UseCases._Supplier.DeleteSupplier
{
    public sealed record DeleteSupplierRequest(Guid Id) : IRequest<DeleteSupplierResponse>;
}
