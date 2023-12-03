using FluentValidation;
namespace FashionTrend.Application.UseCases._ServiceOrder.GetServiceOrderBySupplier
{
    public class GetServiceOrderBySupplierValidator : AbstractValidator<GetServiceOrderBySupplierRequest>
    {
        public GetServiceOrderBySupplierValidator()
        {
            RuleFor(x => x.SupplierId).NotEmpty();
        }
    }
}

