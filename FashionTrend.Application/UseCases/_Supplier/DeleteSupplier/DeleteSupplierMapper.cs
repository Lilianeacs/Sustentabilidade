using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Supplier.DeleteSupplier
{
    public class DeleteSupplierMapper : Profile
    {
        public DeleteSupplierMapper()
        {
            CreateMap<DeleteSupplierRequest, Supplier>();
            CreateMap<Supplier, DeleteSupplierResponse>();
        }
    }
}
