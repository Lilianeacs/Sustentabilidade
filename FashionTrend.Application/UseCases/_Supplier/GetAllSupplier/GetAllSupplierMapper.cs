using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Supplier.GetAllSupplier
{
    public class GetAllSupplierMapper : Profile
    {
        public GetAllSupplierMapper()
        {
            CreateMap<GetAllSupplierRequest, Supplier>();
            CreateMap<Supplier, GetAllSupplierResponse>();
        }
    }
}
