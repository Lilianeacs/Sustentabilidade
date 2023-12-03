using MediatR;
namespace FashionTrend.Application.UseCases._ServiceOrder.DeleteServiceOrder
{
    public sealed record DeleteServiceOrderRequest(Guid Id)
                      : IRequest<DeleteServiceOrderResponse>;

}
