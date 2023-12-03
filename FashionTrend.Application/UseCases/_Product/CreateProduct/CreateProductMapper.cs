using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Product.CreateProduct
{
    public class CreateProductMapper : Profile
    {
        public CreateProductMapper()
        {
            CreateMap<CreateProductRequest, Product>();
            CreateMap<Product, CreateProductResponse>();
        }
    }
}