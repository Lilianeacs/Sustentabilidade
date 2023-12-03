using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionTrend.Application.UseCases._Message
{
    public class CreateMessageValidator : AbstractValidator<CreateMessageRequest>
    {
        public CreateMessageValidator()
        {
            RuleFor(x => x.topic).NotEmpty();
            RuleFor(x => x.content).NotEmpty();
        }
    }
}
