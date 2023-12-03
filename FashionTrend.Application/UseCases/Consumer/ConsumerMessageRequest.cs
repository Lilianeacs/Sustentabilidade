using MediatR;

namespace FashionTrend.Application.UseCases.Consumer
{
    public sealed record ConsumerMessageRequest(string topic, string group) : IRequest<string>;   
}