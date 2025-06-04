using AutoMapper;
using BabyCareProject.Dtos.ContactDtos;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models;

public class ContactManager : IContactService
{
    private readonly IMongoCollection<Contact> _contactCollection;
    private readonly IMapper _mapper;
    public ContactManager(IMapper mapper, IDataBaseSettings dataBaseSettings)
    {
        var client = new MongoClient(dataBaseSettings.ConnectionStrings);
        var database = client.GetDatabase(dataBaseSettings.DataBaseName);
        _contactCollection = database.GetCollection<Contact>(dataBaseSettings.ContactCollection);
        _mapper = mapper;
    }
    public async Task CreateAsync(CreateContactDto contactDto)
    {
        var contact=_mapper.Map<Contact>(contactDto);
        await _contactCollection.InsertOneAsync(contact);
    }

    public async Task DeleteAsync(string id)
    {
        await _contactCollection.DeleteOneAsync(id);
    }

    public async Task<List<ResultContactDto>> GetAllAsync()
    {
        var contacts = await _contactCollection.AsQueryable().ToListAsync();
        return  _mapper.Map<List<ResultContactDto>>(contacts);  
    }

    public async Task<UpdateContactDto> GetByIdAsync(string id)
    {
        var contact=await _contactCollection.Find(c=>c.Id==id).FirstOrDefaultAsync();
        return _mapper.Map<UpdateContactDto>(contact);
    }

    public async Task UpdateAsync(UpdateContactDto contactDto)
    {
        var contact= _mapper.Map<Contact>(contactDto);
        await _contactCollection.FindOneAndReplaceAsync(c=>c.Id==contact.Id, contact);

    }
}

