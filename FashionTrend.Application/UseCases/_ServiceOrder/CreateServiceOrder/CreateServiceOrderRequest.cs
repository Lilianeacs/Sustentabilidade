using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._ServiceOrder.CreateServiceOrder
{
    public sealed record CreateServiceOrderRequest(
        Guid SupplierId,
        Guid ServiceId,
        DateTime EstimatedDate,
        EServiceStatus Status
        ) : IRequest<CreateServiceOrderResponse>;

}

