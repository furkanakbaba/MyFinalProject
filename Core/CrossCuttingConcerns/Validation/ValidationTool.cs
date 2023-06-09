﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {//ıvalidator bizim productvalidatordan aldığımız validatordür. burada validatorümğz producttır.
        public static void Validate(IValidator validator,object entity)
        {
            var context = new ValidationContext<object>(entity);
            var result = validator.Validate(context);
            if (!result.IsValid)//geçerli değilse
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
