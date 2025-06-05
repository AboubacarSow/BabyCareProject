using BabyCareProject.Dtos.TestimonialDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Testimonial;

public class TestimonialValidator : AbstractValidator<TestimonialManipulation>
{
    public TestimonialValidator()
    {
        RuleFor(t => t.FullName)
        .NotEmpty()
        .WithMessage("Ad Soyad Alanı Boş Geçilemez");

        RuleFor(t => t.Comment)
        .NotEmpty()
        .WithMessage("Yorum Alanı Boş Geçilemez")
        .When(t => !string.IsNullOrWhiteSpace(t.FullName));

        RuleFor(t => t.Title)
        .NotEmpty()
        .WithMessage("Lütfen Başlık Giriniz")
        .When(t => !string.IsNullOrWhiteSpace(t.Comment));

        RuleFor(t => t.Rate)
        .NotEmpty()
        .WithMessage("Lütfen Puanınızı Giriniz")
        .Matches(@"^[1-7]$")
        .WithMessage("Puan yalnızca 1-7 arası bir rakam olmalıdır")
        .When(t => !string.IsNullOrWhiteSpace(t.Title));

    }
}
