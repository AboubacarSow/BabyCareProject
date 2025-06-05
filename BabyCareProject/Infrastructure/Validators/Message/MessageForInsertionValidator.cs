using BabyCareProject.Dtos.MessageDtos;
using FluentValidation;

namespace BabyCareProject.Infrastructure.Validators.Message;

public class MessageForInsertionValidator: AbstractValidator<CreateMessageDto>
{ 
    public MessageForInsertionValidator() 
    {
        Include(new MessageValidator());
    } 
}
