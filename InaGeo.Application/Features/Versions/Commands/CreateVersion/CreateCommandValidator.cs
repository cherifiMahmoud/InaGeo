using FluentValidation;

namespace InaGeo.Application.Features.Versions.Commands.CreateVersion
{
    public class CreateCommandValidator : AbstractValidator<CreateVersionCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(V => V.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(40);
        }
    }
}
