using FluentValidation;
namespace FashionTrend.Application.UseCases._Product.DeleteProduct
{
    public class DeleteProductValidator :
        AbstractValidator<DeleteProductRequest>
    {
        public DeleteProductValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
        }
    }
}
