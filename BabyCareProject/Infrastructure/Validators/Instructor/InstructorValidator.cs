using BabyCareProject.Dtos.InstructorDtos;
using FluentValidation;
namespace BabyCareProject.Infrastructure.Validators.Instructor;
public class InstructorValidator : AbstractValidator<InstructorManipulation>
{
    public InstructorValidator()
    {
        RuleFor(i => i.FirstName)
            .NotEmpty().WithMessage("Eğitmen Adı Boş Geçilemez");

        RuleFor(i => i.LastName)
            .NotEmpty().WithMessage("Eğitmen Soyadı Boş Geçilemez")
            .When(i => !String.IsNullOrWhiteSpace(i.FirstName));
        RuleFor(i => i.Title)
            .NotEmpty().WithMessage("Eğitmen Ünvanı Boş Geçilemez")
            .When(i => !String.IsNullOrWhiteSpace(i.LastName));
    }

}
