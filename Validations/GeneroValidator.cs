using APIpeliculas.Models;
using FluentValidation;

namespace APIpeliculas.Validations
{
    public class GeneroValidator:AbstractValidator<GeneroInput>
    {
        public GeneroValidator()
        {
            RuleFor(g => g.Nombre).Empty()
                .MaximumLength(50)
                .NotNull()
                .MinimumLength(5).WithMessage("Hola mundo");
        }
    }

}
