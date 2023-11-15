using MediatR;

namespace FashionTrend.Application.UseCases._Service.DeleteService
{
    public sealed record DeleteServiceRequest(Guid Id) : IRequest<DeleteServiceResponse>;
}
