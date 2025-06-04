using BabyCareProject.Dtos.SubscriberDtos;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;

namespace BabyCareProject.Services.Models;

public class SubscriberManager : ISubscriberService
{
    public Task CreateAsync(CreateSubscriberDto subscriberDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ResultSubscriberDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UpdateSubscriberDto> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UpdateSubscriberDto subscriberDto)
    {
        throw new NotImplementedException();
    }
}
