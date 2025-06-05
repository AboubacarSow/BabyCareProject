using BabyCareProject.Dtos.TestimonialDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Testimonial;

public class TestimonialForEditValidator : AbstractValidator<UpdateTestimonialDto>
{
    public TestimonialForEditValidator()
    {
        Include(new TestimonialValidator());
        RuleFor(t=>t.ImageUrl)
        .NotEmpty()
        .WithMessage("Resim Yolu Boş Olamaz");
    }
}
