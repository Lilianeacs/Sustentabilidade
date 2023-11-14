using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Supplier.UpdateSupplier
{
    public sealed class UpdateSupplierMapper : Profile
    {
        public UpdateSupplierMapper()
        {
            CreateMap<UpdateSupplierRequest, Supplier>();
            CreateMap<Supplier, UpdateSupplierResponse>();
        }
    }
}
