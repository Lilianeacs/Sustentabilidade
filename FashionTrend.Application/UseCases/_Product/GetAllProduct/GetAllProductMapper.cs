using AutoMapper;
using FashionTrend.Domain.Entities;
namespace FashionTrend.Application.UseCases._Product.GetAllProduct
{
    public sealed class GetAllProductMapper : Profile
    {
        public GetAllProductMapper()
        {
            CreateMap<Product, GetAllProductResponse>();
        }
    }
}
