using BabyCareProject.Dtos.EventDtos;
using FluentValidation;

namespace BabyCareProject.Infracture.Validators.Event;
public partial class EventValidator
{
    public class EventForUpdateValidator:AbstractValidator<UpdateEventDto>
    {
        public EventForUpdateValidator()
        {
            Include(new EventValidator());
            RuleFor(e => e.ImageUrl)
            .NotEmpty().WithMessage("Etkinlik Resmi Boş Geçilemez");
        }
    }
}

