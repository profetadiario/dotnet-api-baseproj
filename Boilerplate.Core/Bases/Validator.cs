using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Boilerplate.Core.Bases
{
    public abstract class Validator
    {
        public ValidationResult ErrorMessages { get; private set; }
        public bool IsValid { get; private set; }

        protected bool ValidateModel<TModel>(TModel model, AbstractValidator<TModel> validator, bool throwWhenFailure = false) 
        {
            if (throwWhenFailure)
                validator.ValidateAndThrow(model);

            ErrorMessages = validator.Validate(model);

            return IsValid = ErrorMessages.IsValid;
        }
    }
}
