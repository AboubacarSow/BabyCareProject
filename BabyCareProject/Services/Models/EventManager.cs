using AutoMapper;
using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Infrastructure.Utilities;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models
{
    public class EventManager : IEventService
    {
        private readonly IMongoCollection<Event> _eventCollection;
        private readonly IMapper _mapper;
        public EventManager(IMapper mapper, IDataBaseSettings dataBaseSettings)
        {
            var client = new MongoClient(dataBaseSettings.ConnectionStrings);
            var database = client.GetDatabase(dataBaseSettings.DataBaseName);
            _eventCollection = database.GetCollection<Event>(dataBaseSettings.EventCollection);
            _mapper = mapper;
        }
        public async Task CreateAsync(CreateEventDto eventDto)
        {
            eventDto.ImageUrl = await Media.UploadAsync(eventDto.ImageFile);
            var _event = _mapper.Map<Event>(eventDto);
            await _eventCollection.InsertOneAsync(_event);
        }

        public async Task DeleteAsync(string id)
        {
            await _eventCollection.DeleteOneAsync(id);
        }

        public async Task<List<ResultEventDto>> GetAllAsync()
        {
            var events = await _eventCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultEventDto>>(events);
        }

        public async Task<UpdateEventDto> GetByIdAsync(string id)
        {
            var _event = await _eventCollection.Find(c => c.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateEventDto>(_event);
        }

        public async Task UpdateAsync(UpdateEventDto eventDto)
        {
            eventDto.ImageUrl = await Media.UploadAsync(eventDto.ImageFile);
            var _event = _mapper.Map<Event>(eventDto);
            await _eventCollection.FindOneAndReplaceAsync(c => c.Id == _event.Id, _event);

        }
        
    }
}
