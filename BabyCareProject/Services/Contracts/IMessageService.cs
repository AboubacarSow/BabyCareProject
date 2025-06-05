using BabyCareProject.Dtos.MessageDtos;

namespace BabyCareProject.Services.Contracts;

public interface IMessageService
{
    Task<List<ResultMessageDto>> GetAllAsync();
    Task CreateAsync(CreateMessageDto messageDto);
    Task DeleteAsync(string id);
}
