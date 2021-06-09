using Boilerplate.Core.Models;
using FluentValidation;

namespace Boilerplate.Core.Validators
{
    class FornecedorModelValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorModelValidation()
        {
            RuleFor(x => x.Link)
                .Must(c => c.Contains(".com")).WithMessage("O campo {PropertyName} precisa ter .'com'");

            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser nulo")
                .Length(1,100).WithMessage("O campo {PropertyName} precisa ter entre 1 e 100 caracteres");

            RuleFor(x => x.MantemHistorico)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser nulo");

            RuleFor(x => x.Vertical)
                .NotEmpty().WithMessage("O campo {PropertyName} não pode ser nulo");
        }
    }
}
