using MediatR;

namespace FashionTrend.Application.UseCases._Product.GetAllProduct
{
    public sealed record GetAllProductRequest : 
                       IRequest<List<GetAllProductResponse>>;
}
