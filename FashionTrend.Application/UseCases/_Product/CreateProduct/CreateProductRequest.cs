using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Product.CreateProduct
{
    public sealed record CreateProductRequest(
        string Name,
        string Description,
        List<EMaterial> Materials
        ) : IRequest<CreateProductResponse>;
}
