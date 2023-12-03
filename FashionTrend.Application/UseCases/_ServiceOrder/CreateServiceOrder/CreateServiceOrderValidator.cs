using FluentValidation;

namespace FashionTrend.Application.UseCases._ServiceOrder.CreateServiceOrder
{
    public sealed class CreateServiceOrderValidator : AbstractValidator<CreateServiceOrderRequest>
    {
        public CreateServiceOrderValidator()
        {
            RuleFor(x => x.SupplierId).NotEmpty();
            RuleFor(x => x.ServiceId).NotEmpty();

        }
    }
}
