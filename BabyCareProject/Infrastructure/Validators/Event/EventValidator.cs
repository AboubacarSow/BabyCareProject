using BabyCareProject.Dtos.EventDtos;
using FluentValidation;

namespace BabyCareProject.Infracture.Validators.Event;
public partial class EventValidator : AbstractValidator<EventManipulation>
{
    public EventValidator()
    {
        RuleFor(e => e.Name)
            .NotEmpty().WithMessage("Etkinlik İsmini Boş Geçirilemez");
        RuleFor(e => e.Location)
            .NotEmpty().WithMessage("Etkinlik Yeri Alanı Boş Geçerilemez")
            .When(e => !String.IsNullOrWhiteSpace(e.Location));
        RuleFor(e => e.Date)
            .NotEmpty().WithMessage("Tarih Alanı Boş Geçirilemez");
        RuleFor(e => e.StartAt)
            .NotEmpty().WithMessage("Başlangıç Saati Alanı Boş Geçilemez")
            .When(e => !String.IsNullOrWhiteSpace(e.Date));
        RuleFor(e => e.EndAt)
            .NotEmpty().WithMessage("Bitiş Saati Alanı Boş Geçilemez")
            .When(e => !String.IsNullOrWhiteSpace(e.StartAt));
        RuleFor(e => e.Description)
            .NotEmpty().WithMessage("Açıklama Alanı Boş Geçilemez")
            .MinimumLength(20).WithMessage("Açıklama Alanı en az 20 karakter olmalıdır")
            .When(e=>!String.IsNullOrEmpty(e.EndAt));
    }
}

