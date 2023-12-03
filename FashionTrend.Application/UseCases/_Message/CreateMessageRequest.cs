using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Application.UseCases._Message
{
    public sealed record CreateMessageRequest(string topic, string sender, string receiver, string content) : IRequest<CreateMessageResponse>;
}
