using AutoMapper;
using BabyCareProject.Dtos.MessageDtos;
using BabyCareProject.Dtos.ServiceDtos;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models;
public class MessageManager : IMessageService
{
    private readonly IMongoCollection<Message> _messageCollection;
    private readonly IMapper _mapper;
    public MessageManager(IMapper mapper, IDataBaseSettings dataBaseSettings)
    {
        _mapper = mapper;
        var client = new MongoClient(dataBaseSettings.ConnectionStrings);
        var database = client.GetDatabase(dataBaseSettings.DataBaseName);
        _messageCollection = database.GetCollection<Message>(dataBaseSettings.MessageCollection);
    }
    public async Task CreateAsync(CreateMessageDto messageDto)
    {
        var message = _mapper.Map<Message>(messageDto);
        await _messageCollection.InsertOneAsync(message);
    }
    public async Task DeleteAsync(string id)
    {
        await _messageCollection.DeleteOneAsync(ms => ms.Id==id);
    }
    public async Task<List<ResultMessageDto>> GetAllAsync()
    {
        var messages = await _messageCollection.AsQueryable().ToListAsync();
        return _mapper.Map<List<ResultMessageDto>>(messages);
    }
    public async Task<UpdateMessageDto> GetByIdAsync(string id)
    {
        var message = await _messageCollection.Find(ms => ms.Id == id).FirstOrDefaultAsync();
        return _mapper.Map<UpdateMessageDto>(message);
    }
    public async Task UpdateAsync(UpdateMessageDto messageDto)
    {
        var message = _mapper.Map<Message>(messageDto);
        await _messageCollection.FindOneAndReplaceAsync(s => s.Id == message.Id, message);
    }
}
