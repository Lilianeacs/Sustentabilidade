using AutoMapper;
using FashionTrend.Domain.Entities;
namespace FashionTrend.Application.UseCases._ServiceOrder.UpdateServiceOrder
{
    public sealed class UpdateServiceOrderMapper : Profile
    {
        public UpdateServiceOrderMapper()
        {
            CreateMap<UpdateServiceOrderRequest, ServiceOrder>();
            CreateMap<ServiceOrder, UpdateServiceOrderResponse>();
        }
    }
}
