using AutoMapper;
using FashionTrend.Domain.Entities;
namespace FashionTrend.Application.UseCases._Product.GetProductById
{
    public sealed class GetProductByIdMapper : Profile
    {
        public GetProductByIdMapper()
        {
            CreateMap<Product, GetProductByIdResponse>();
        }
    }
}
