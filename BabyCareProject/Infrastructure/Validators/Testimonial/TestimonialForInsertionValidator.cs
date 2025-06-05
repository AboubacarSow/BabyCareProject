using BabyCareProject.Dtos.TestimonialDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Testimonial;

public class TestimonialForInsertionValidator : AbstractValidator<CreateTestimonialDto>
{
    public TestimonialForInsertionValidator()
    {
        Include(new TestimonialValidator());
        
        RuleFor(e => e.ImageFile)
            .NotNull().WithMessage("Resim Boş Geçilemez")
            .Must(file => file?.Length > 0).WithMessage("Lütfen bir resim dosyası seçiniz")
            .When(e => !string.IsNullOrWhiteSpace(e.Rate));

    }
}
