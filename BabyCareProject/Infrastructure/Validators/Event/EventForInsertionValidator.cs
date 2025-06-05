using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Infracture.Validators.Event;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Event;
public class EventForInsertionValidator:AbstractValidator<CreateEventDto>
{
    public EventForInsertionValidator()
    {
        Include(new EventValidator());
        RuleFor(e => e.ImageFile)
            .NotNull().WithMessage("Etkinlik Resmi Boş Geçilemez")
            .Must(file => file?.Length > 0).WithMessage("Lütfen bir resim dosyası seçiniz")
            .When(e => !string.IsNullOrWhiteSpace(e.Location));
    }
}


  