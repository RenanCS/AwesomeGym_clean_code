using AwesomeGym.Application.InputModels;
using FluentValidation;

namespace AwesomeGym.Application.Validators
{
    public class UnidadeInputModelValidator : AbstractValidator<UnidadeInputModel>
    {
        public UnidadeInputModelValidator()
        {
            RuleFor(cp => cp.Nome)
                .NotEmpty()
                .WithMessage("Nome da unidade deve ser válido");

            RuleFor(cp => cp.EnderecoCompleto)
                .NotNull()
                .NotEmpty()
                .WithMessage("Endereço completo deve ser váido");
        }
    }
}
