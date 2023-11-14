using AutoMapper;
using FashionTrend.Application.UseCases._Supplier.CreateSupplier;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Supplier.CreateSupplier
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