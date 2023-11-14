using FluentValidation;

namespace FashionTrend.Application.UseCases._Supplier.DeleteSupplier
{
    public class DeleteSupplierValidator : AbstractValidator<DeleteSupplierRequest>
    {
        public DeleteSupplierValidator()
        {
            RuleFor(x => x.Id).NotEmpty().NotNull();
        }
    }
}
