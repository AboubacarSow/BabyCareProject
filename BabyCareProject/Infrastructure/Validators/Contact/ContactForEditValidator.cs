using BabyCareProject.Dtos.ContactDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Contact;

public class ContactForEditValidator: AbstractValidator<UpdateContactDto>
{
    public ContactForEditValidator()
    {
        Include(new ContactValidator());
    }
}
