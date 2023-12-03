using MediatR;
namespace FashionTrend.Application.UseCases._Product.GetProductById
{
    public sealed record GetProductByIdRequest(Guid Id)
                      : IRequest<GetProductByIdResponse>;
}
