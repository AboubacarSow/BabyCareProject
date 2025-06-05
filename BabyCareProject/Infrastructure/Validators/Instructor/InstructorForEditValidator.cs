using BabyCareProject.Dtos.InstructorDtos;
using FluentValidation;
namespace BabyCareProject.Infrastructure.Validators.Instructor;

public class InstructorForEditValidator : AbstractValidator<UpdateInstructorDto>
{
    public InstructorForEditValidator()
    {
        Include(new InstructorValidator());
        RuleFor(i => i.ImageUrl)
            .NotEmpty().WithMessage("Eğitmen Resmi Boş Geçilemez");
    }
}
