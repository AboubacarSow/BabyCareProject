using BabyCareProject.Dtos.ContactDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Contact;

public class ContactForInsertionValidator: AbstractValidator<CreateContactDto>
{
    public ContactForInsertionValidator()
    {
        Include(new ContactValidator());
    }
}
