using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Service.GetAllService
{
    public class GetAllServiceMapper : Profile
    {
        public GetAllServiceMapper()
        {
            CreateMap<GetAllServiceRequest, Service>();
            CreateMap<Service, GetAllServiceResponse>();
        }
    }
}
