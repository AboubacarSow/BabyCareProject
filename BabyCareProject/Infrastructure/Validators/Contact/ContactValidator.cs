using BabyCareProject.Dtos.ContactDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Contact;

public class ContactValidator : AbstractValidator<ContactManipulation>
{
    public ContactValidator()
    {
        RuleFor(c => c.Address)
            .NotEmpty().WithMessage("Adres Boş Geçilemez")
            .MinimumLength(10).WithMessage("Tam Adresi girmelisiniz");
        RuleFor(c => c.Email)
            .NotEmpty().WithMessage("Mail adresi Boş Geçilemez")
            .EmailAddress().WithMessage("Geçerli bir mail adresi giriniz")
            .When(c => !String.IsNullOrEmpty(c.Email));
        RuleFor(c => c.Tel)
            .NotEmpty().WithMessage("Telefon numarası Boş Geçilemez")
            .Matches(@"^\+?[0-9]{10,15}$").WithMessage("Geçerli bir telefon numarası giriniz")
            .When(c => !String.IsNullOrEmpty(c.Tel));
        RuleFor(c => c.LocationUrl)
            .NotEmpty().WithMessage("Konum URL'si Boş Geçilemez")
            .Matches(@"^https:\/\/maps\.app\.goo\.gl\/[a-zA-Z0-9]+$").WithMessage("Geçerli bir URL giriniz")
            .When(c => !String.IsNullOrEmpty(c.Tel));
        RuleFor(c => c.MapUrl)
            .NotEmpty().WithMessage("Harita URL'si Boş Geçilemez")
            .Matches(@"^https:\/\/www\.google\.com\/maps\/embed\?pb=[A-Za-z0-9!%:_\-.=]+$").WithMessage("Geçerli bir URL giriniz")
            .When(c => !String.IsNullOrEmpty(c.MapUrl));

    }
}
