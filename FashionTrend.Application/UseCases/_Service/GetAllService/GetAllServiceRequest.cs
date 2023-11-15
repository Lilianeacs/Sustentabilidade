using MediatR;

namespace FashionTrend.Application.UseCases._Service.GetAllService
{
    public sealed record GetAllServiceRequest : IRequest<List<GetAllServiceResponse>>;
}
