using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._ServiceOrder.UpdateServiceOrder
{
    public sealed record UpdateServiceOrderRequest(
        Guid Id,
        EServiceStatus Status,
        bool Payed
        ) : IRequest<UpdateServiceOrderResponse>;
}
