using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases.CreateSupplier
{
    public class CreateSupplierMapper : Profile
    {
        public CreateSupplierMapper() 
        {
            CreateMap<CreateSupplierRequest, Supplier>();
            CreateMap<Supplier, CreateSupplierResponse>();
        }
    }
}
