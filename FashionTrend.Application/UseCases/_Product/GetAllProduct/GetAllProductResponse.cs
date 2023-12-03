using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Product.GetAllProduct
{
    public sealed record GetAllProductResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<EMaterial> Materials { get; set; }
    }
}
