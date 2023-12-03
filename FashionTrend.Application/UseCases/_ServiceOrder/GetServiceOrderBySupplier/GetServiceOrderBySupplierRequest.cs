using MediatR;
namespace FashionTrend.Application.UseCases._ServiceOrder.GetServiceOrderBySupplier
{
    public sealed record GetServiceOrderBySupplierRequest(Guid SupplierId) : 
                       IRequest<List<GetServiceOrderBySupplierResponse>>;
}
