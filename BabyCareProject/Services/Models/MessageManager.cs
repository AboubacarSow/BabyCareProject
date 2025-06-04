using BabyCareProject.Dtos.MessageDtos;
using BabyCareProject.Services.Contracts;

namespace BabyCareProject.Services.Models;

public class MessageManager : IMessageService
{
    public Task CreateAsync(CreateMessageDto messageDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ResultMessageDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UpdateMessageDto> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UpdateMessageDto messageDto)
    {
        throw new NotImplementedException();
    }
}
