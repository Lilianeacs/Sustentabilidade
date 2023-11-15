using FluentValidation;

namespace FashionTrend.Application.UseCases._Service.DeleteService
{
    public class DeleteServiceValidator : AbstractValidator<DeleteServiceRequest>
    {
        public DeleteServiceValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();
        }
    }
}
