using FluentValidation;

namespace FashionTrend.Application.UseCases._Product.GetProductById
{
    public class GetProductByIdValidator : AbstractValidator<GetProductByIdRequest>
    {
        public GetProductByIdValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
