using FluentValidation;

namespace FashionTrend.Application.UseCases.Consumer
{
    public sealed class ConsumerMessageValidator : AbstractValidator<ConsumerMessageRequest>
    {
        public ConsumerMessageValidator()
        {
            RuleFor(x => x.topic).NotEmpty();
            RuleFor(x => x.group).NotEmpty();
        }

    }
}