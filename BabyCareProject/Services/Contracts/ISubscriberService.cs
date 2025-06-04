using BabyCareProject.Dtos.SubscriberDtos;

namespace BabyCareProject.Services.Contracts;

public interface ISubscriberService
{
    Task<List<ResultSubscriberDto>> GetAllAsync();
    Task<UpdateSubscriberDto> GetByIdAsync(string id);
    Task CreateAsync(CreateSubscriberDto subscriberDto);
    Task UpdateAsync(UpdateSubscriberDto subscriberDto);
    Task DeleteAsync(string id);
}

