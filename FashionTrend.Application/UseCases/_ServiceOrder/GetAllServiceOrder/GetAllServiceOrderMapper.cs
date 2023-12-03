using AutoMapper;
using FashionTrend.Domain.Entities;
namespace FashionTrend.Application.UseCases._ServiceOrder.GetAllServiceOrder
{
    public sealed class GetAllServiceOrderMapper : Profile
    {
        public GetAllServiceOrderMapper()
        {
            CreateMap<ServiceOrder, GetAllServiceOrderResponse>();
        }
    }
}
