using AutoMapper;
using FashionTrend.Domain.Entities;
namespace FashionTrend.Application.UseCases._Product.DeleteProduct
{
    public sealed class DeleteProductMapper : Profile
    {
        public DeleteProductMapper()
        {
            CreateMap<DeleteProductRequest, Product>();
            CreateMap<Product, DeleteProductResponse>();
        }
    }
}
