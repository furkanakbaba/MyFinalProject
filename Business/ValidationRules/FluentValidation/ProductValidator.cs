using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product> //Abstract Validator Fluent Validation destekli bir abstract sınıftır ve generic olarak iş yapar.
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();//product adı boş geçilemez.
            RuleFor(p => p.ProductName).MinimumLength(2);//productName i en az iki karakterli olmalıdır
            RuleFor(p => p.UnitPrice).NotEmpty();//ücreti boş geçilemez
            RuleFor(p => p.UnitPrice).GreaterThan(0);//0 dan büyük olmalı
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
        }
    }
}
