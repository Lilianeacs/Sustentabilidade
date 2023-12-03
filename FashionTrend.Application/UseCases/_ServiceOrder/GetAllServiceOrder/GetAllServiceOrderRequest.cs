using MediatR;
namespace FashionTrend.Application.UseCases._ServiceOrder.GetAllServiceOrder
{
    public sealed record GetAllServiceOrderRequest : 
                       IRequest<List<GetAllServiceOrderResponse>>;
}
