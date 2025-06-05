using BabyCareProject.Dtos.AboutDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.About;
public class AboutValidator : AbstractValidator<AboutManipulation>
{
    public AboutValidator()
    {
        RuleFor(x => x.Slogan)
            .NotEmpty().WithMessage("Lütfen bir slogan giriniz.")
            .MinimumLength(10).WithMessage("Slog en az 10 karakter olmalıdır");

        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("Açıklama Boş Geçilemez")
            .MaximumLength(50).WithMessage("Açıklama en az 50 karakter Olmalıdır.")
            .When(x=>!string.IsNullOrEmpty(x.Slogan));

        RuleFor(x => x.VideoID)
            .NotEmpty().WithMessage("Video ID'si gereklidir.")
            .When(x => !string.IsNullOrEmpty(x.Description));
        RuleFor(x => x.FeatureContent)
            .NotEmpty().WithMessage("Özellik alanı Boş Geçilemez")
            .Must(x => x.Contains(',')).WithMessage("Özellikler virgül ile ayırmalısınız")
            .Must(x => x.Split(',')
                        .Select(a => a.Trim())
                        .Count(a => !string.IsNullOrEmpty(x)) >= 2)
                        .WithMessage("En az iki Özellik Girmelisiniz")
            .When(x => !string.IsNullOrEmpty(x.VideoID));
        
    }
}
