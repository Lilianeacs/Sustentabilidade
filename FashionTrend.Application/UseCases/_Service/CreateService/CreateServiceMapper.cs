using AutoMapper;
using FashionTrend.Application.UseCases._Service.CreateService;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Service.CreateService
{
    public class CreateServiceMapper : Profile
    {
        public CreateServiceMapper()
        {
            CreateMap<CreateServiceRequest, Service>();
            CreateMap<Service, CreateServiceResponse>();
        }
    }
}