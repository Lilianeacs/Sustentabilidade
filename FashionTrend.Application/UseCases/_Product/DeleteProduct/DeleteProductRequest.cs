using MediatR;
namespace FashionTrend.Application.UseCases._Product.DeleteProduct
{
    public sealed record DeleteProductRequest(Guid Id)
                      : IRequest<DeleteProductResponse>;
}
