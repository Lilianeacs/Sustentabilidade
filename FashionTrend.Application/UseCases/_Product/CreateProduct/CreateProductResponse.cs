using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Product.CreateProduct
{
    public sealed record CreateProductResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<EMaterial> Materials { get; set; }

    }
}