using MediatR;
namespace FashionTrend.Application.UseCases._ServiceOrder.GetServiceOrderById
{
    public sealed record GetServiceOrderByIdRequest(Guid Id) : 
                       IRequest<GetServiceOrderByIdResponse>;
}
