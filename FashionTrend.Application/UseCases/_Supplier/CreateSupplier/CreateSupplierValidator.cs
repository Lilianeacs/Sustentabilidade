﻿using FluentValidation;
using FashionTrend.Application.UseCases._Supplier.CreateSupplier;


namespace FashionTrend.Application.UseCases._Supplier.CreateSupplier
{
    public class CreateSupplierValidator : AbstractValidator<CreateSupplierRequest>
    {
        public CreateSupplierValidator() 
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(50);
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
        }
        
    }
}