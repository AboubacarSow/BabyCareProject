using BabyCareProject.Dtos.EventDtos;

namespace BabyCareProject.Services.Contracts;

public interface IEventService
{
    Task<List<ResultEventDto>> GetAllAsync();
    Task<UpdateEventDto> GetByIdAsync(string id);
    Task CreateAsync(CreateEventDto eventDto);
    Task UpdateAsync(UpdateEventDto eventDto);
    Task DeleteAsync(string id);
}

