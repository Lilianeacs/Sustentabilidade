using AutoMapper;
using FashionTrend.Domain.Entities;
namespace FashionTrend.Application.UseCases._ServiceOrder.GetServiceOrderBySupplier
{
    public sealed class GetServiceOrderBySupplierMapper : Profile
    {
        public GetServiceOrderBySupplierMapper()
        {
            CreateMap<ServiceOrder, GetServiceOrderBySupplierResponse>();
        }
    }
}
