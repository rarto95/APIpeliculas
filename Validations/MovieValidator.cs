using APIpeliculas.Models;
using FluentValidation;
using System.Globalization;

namespace APIpeliculas.Validations
{
    public class MovieValidator:AbstractValidator<MovieInput>
    {
        public MovieValidator()
        {
            //titulo
            RuleFor(m => m.Titulo).NotNull().WithMessage("El titulo es obligatorio.")
                .NotEmpty().WithMessage("El titulo es obligatorio.")
                .MaximumLength(50).WithMessage("El titulo es obligatorio.");
            //descripcion
            RuleFor(m => m.Description)
                .NotEmpty().WithMessage("La descripcion es obligatoria.")
                .MaximumLength(500).WithMessage("La descripcion es obligatoria.");
            //duracion

            //director
            RuleFor(m => m.Director).NotNull()
                .NotEmpty().WithMessage("La descripcion es obligatoria.")
                .MaximumLength(50).WithMessage("El director no debe estar vacio");
            //estreno
            RuleFor(m => m.Estreno).NotEmpty().WithMessage("La descripcion es obligatoria.")
                .NotNull().WithMessage("La descripcion es obligatoria.")
                .GreaterThan(1800).WithMessage("La fecha tiene que ir en formato de año ####.")
                .LessThan(DateTime.Today.Year).WithMessage("La fecha tiene que ser menor o igual a la fecha.");

            //genero
            RuleFor(m => m.GeneroId).NotNull();
        }
    }
}
