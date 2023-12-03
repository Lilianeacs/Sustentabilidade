using AutoMapper;
using FashionTrend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Application.UseCases._Message
{
    public class CreateMessageMapper : Profile
    {
        public CreateMessageMapper()
        {
            CreateMap<CreateMessageRequest, Message>();
            CreateMap<Message, CreateMessageResponse>();
        }
    }
}
