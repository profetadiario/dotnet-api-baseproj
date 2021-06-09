using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Boilerplate.Core.Bases
{
    public abstract class Validator
    {
        [NotMapped]
        public ValidationResult ErrorMessages { get; private set; }
        [NotMapped]
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
