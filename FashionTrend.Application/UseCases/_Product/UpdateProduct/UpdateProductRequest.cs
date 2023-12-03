using MediatR;
using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Product.UpdateProduct
{
    public sealed record UpdateProductRequest(
        Guid Id,
        string Name,
        string Description,
        List<EMaterial> Materials
        ) : IRequest<UpdateProductResponse>;
}
