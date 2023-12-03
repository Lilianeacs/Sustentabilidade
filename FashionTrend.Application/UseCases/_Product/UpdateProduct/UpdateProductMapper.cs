using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Product.UpdateProduct
{
    public sealed class UpdateProductMapper : Profile
    {
        public UpdateProductMapper()
        {
            CreateMap<UpdateProductRequest, Product>();
            CreateMap<Product, UpdateProductResponse>();
        }
    }
}
