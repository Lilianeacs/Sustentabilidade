using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._ServiceOrder.DeleteServiceOrder
{
    public sealed class DeleteServiceOrderMapper : Profile
    {
        public DeleteServiceOrderMapper()
        {
            CreateMap<DeleteServiceOrderRequest, ServiceOrder>();
            CreateMap<ServiceOrder, DeleteServiceOrderResponse>();
        }
    }
}
