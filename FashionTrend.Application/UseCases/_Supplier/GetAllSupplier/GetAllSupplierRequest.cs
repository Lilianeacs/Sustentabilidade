using MediatR;

namespace FashionTrend.Application.UseCases._Supplier.GetAllSupplier
{
    public sealed record GetAllSupplierRequest : IRequest<List<GetAllSupplierResponse>>;
}
