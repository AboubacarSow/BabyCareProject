using BabyCareProject.Dtos.InstructorDtos;
using FluentValidation;
namespace BabyCareProject.Infrastructure.Validators.Instructor;

public class InstructorForInsertionValidator: AbstractValidator<CreateInstructorDto>
{
    public InstructorForInsertionValidator()
    {
        Include(new InstructorValidator());
        RuleFor(i => i.ImageFile)
            .NotNull().WithMessage("Eğitmen Resmi Boş Geçilemez")
            .Must(file => file?.Length > 0).WithMessage("Lütfen bir resim dosyası seçiniz")
            .When(i => !string.IsNullOrWhiteSpace(i.FirstName));
            
    }
}
