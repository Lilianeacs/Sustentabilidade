using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases._Service.DeleteService
{
    public class DeleteServiceMapper : Profile
    {
        public DeleteServiceMapper()
        {
            CreateMap<DeleteServiceRequest, Service>();
            CreateMap<Service, DeleteServiceResponse>();
        }
    }
}
