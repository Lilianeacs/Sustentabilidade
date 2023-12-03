using AutoMapper;
using FashionTrend.Domain.Entities;

namespace FashionTrend.Application.UseCases.Consumer
{
    public class ConsumerMessageMapper : Profile
    {
        public ConsumerMessageMapper()
        {
            CreateMap<ConsumerMessageRequest, MessageReceivedEventArgs>();
        }
    }
}
