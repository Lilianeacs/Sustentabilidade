﻿using FluentValidation;
using FashionTrend.Application.UseCases._Service.CreateService;


namespace FashionTrend.Application.UseCases._Service.CreateService
{
    public class CreateServiceValidator : AbstractValidator<CreateServiceRequest>
    {
        public CreateServiceValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
        }
        
    }
}