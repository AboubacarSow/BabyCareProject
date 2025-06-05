using BabyCareProject.Dtos.MessageDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Message;
public class MessageValidator: AbstractValidator<MessageManipulation>
{
    public MessageValidator()
    {
        RuleFor(m => m.FullName)
             .NotEmpty().WithMessage("Lütfen Ad Soyadınız Giriniz");
        RuleFor(m => m.Email)
            .NotEmpty().WithMessage("Email Alanı Boş Geçilemez")
            .When(m=>!String.IsNullOrWhiteSpace(m.FullName));
        RuleFor(m => m.Body)
            .NotEmpty().WithMessage("Lütfen Mesajını Giriniz")
            .When(m => !String.IsNullOrWhiteSpace(m.Email));
    }
}
