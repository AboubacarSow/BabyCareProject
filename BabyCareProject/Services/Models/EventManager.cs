using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Services.Contracts;

namespace BabyCareProject.Services.Models
{
    public class EventManager : IEventService
    {
        public Task CreateAsync(CreateEventDto eventDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultEventDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateEventDto> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateEventDto eventDto)
        {
            throw new NotImplementedException();
        }
    }
}
