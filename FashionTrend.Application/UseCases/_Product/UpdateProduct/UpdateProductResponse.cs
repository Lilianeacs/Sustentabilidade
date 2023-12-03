using static FashionTrend.Domain.Entities.ConstantClasses;

namespace FashionTrend.Application.UseCases._Product.UpdateProduct
{
    public sealed record UpdateProductResponse
    {   
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<EMaterial> Materials { get; set; }
    }
}
