using FluentValidation;

namespace FashionTrend.Application.UseCases._ServiceOrder.UpdateServiceOrder
{
    public class UpdateServiceOrderValidator : AbstractValidator<UpdateServiceOrderRequest>
    {
        public UpdateServiceOrderValidator()
        {
            RuleFor(x => x.Status).NotEmpty();
        }
    }
}
