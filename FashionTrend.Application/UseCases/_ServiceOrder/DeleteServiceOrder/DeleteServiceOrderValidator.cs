using FluentValidation;
namespace FashionTrend.Application.UseCases._ServiceOrder.DeleteServiceOrder
{
    public class DeleteServiceOrderValidator :
        AbstractValidator<DeleteServiceOrderRequest>
    {
        public DeleteServiceOrderValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
