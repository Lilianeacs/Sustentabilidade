using FluentValidation;

namespace FashionTrend.Application.UseCases._ServiceOrder.GetServiceOrderById
{
    public class GetServiceOrderByIdValidator : AbstractValidator<GetServiceOrderByIdRequest>
    {
        public GetServiceOrderByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
