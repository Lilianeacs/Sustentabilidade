using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Service.UpdateService
{
    public sealed class UpdateServiceMapper : Profile
    {
        public UpdateServiceMapper()
        {
            CreateMap<UpdateServiceRequest, Service>();
            CreateMap<Service, UpdateServiceResponse>();
        }
    }
}
