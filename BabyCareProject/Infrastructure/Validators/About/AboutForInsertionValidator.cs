using BabyCareProject.Dtos.AboutDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.About;

public class AboutForInsertionValidator: AbstractValidator<CreateAboutDto>
{
    public AboutForInsertionValidator()
    {
        Include(new AboutValidator());
    }
}
