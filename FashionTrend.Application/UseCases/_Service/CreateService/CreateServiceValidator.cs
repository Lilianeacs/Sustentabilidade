using FluentValidation;


namespace FashionTrend.Application.UseCases._Service.CreateService
{
    public class CreateServiceValidator : AbstractValidator<CreateServiceRequest>
    {
        public CreateServiceValidator() 
        {
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.MaterialType).NotEmpty();
        }
        
    }
}