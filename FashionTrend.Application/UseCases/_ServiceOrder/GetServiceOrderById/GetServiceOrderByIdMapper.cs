using AutoMapper;
using FashionTrend.Domain.Entities;
namespace FashionTrend.Application.UseCases._ServiceOrder.GetServiceOrderById
{
    public sealed class GetServiceOrderByIdMapper : Profile
    {
        public GetServiceOrderByIdMapper()
        {
            CreateMap<ServiceOrder, GetServiceOrderByIdResponse>();
        }
    }
}
