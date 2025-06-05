using BabyCareProject.Dtos.AboutDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.About;

public class AboutForEditValidator: AbstractValidator<UpdateAboutDto>
{
    public AboutForEditValidator()
    {
        Include(new AboutValidator());
    }
}