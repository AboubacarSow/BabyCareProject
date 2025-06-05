using BabyCareProject.Dtos.SubscriberDtos;

namespace BabyCareProject.Services.Contracts;

public interface ISubscriberService
{
    Task<List<ResultSubscriberDto>> GetAllAsync();
    Task CreateAsync(CreateSubscriberDto subscriberDto);
    Task DeleteAsync(string id);
}

