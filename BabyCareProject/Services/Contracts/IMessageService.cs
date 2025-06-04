using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Dtos.MessageDtos;

namespace BabyCareProject.Services.Contracts;

public interface IMessageService
{
    Task<List<ResultMessageDto>> GetAllAsync();
    Task<UpdateMessageDto> GetByIdAsync(string id);
    Task CreateAsync(CreateMessageDto messageDto);
    Task UpdateAsync(UpdateMessageDto messageDto);
    Task DeleteAsync(string id);
}
