using AutoMapper;
using BabyCareProject.Dtos.ServiceDtos;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models;
public class HizmetManager : IHizmetService
{
    private readonly IMongoCollection<Service> _serviceCollection;
    private readonly IMapper _mapper;
    public HizmetManager(IMapper mapper,IDataBaseSettings dataBaseSettings)
    {
        _mapper = mapper;
        var client = new MongoClient(dataBaseSettings.ConnectionStrings);
        var database=client.GetDatabase(dataBaseSettings.DataBaseName);
        _serviceCollection = database.GetCollection<Service>(dataBaseSettings.ServiceCollection);
    }
    public async Task CreateAsync(CreateServiceDto servicDto)
    {
        var service=_mapper.Map<Service>(servicDto);    
        await _serviceCollection.InsertOneAsync(service);   
    }

    public async Task DeleteAsync(string id)
    {
        await _serviceCollection.DeleteOneAsync(id);    
    }

    public async Task<List<ResultServiceDto>> GetAllAsync()
    {
        var services = await _serviceCollection.AsQueryable().ToListAsync();
        return _mapper.Map<List<ResultServiceDto>>(services);
    }

    public async Task<UpdateServiceDto> GetByIdAsync(string id)
    {
        var service = await _serviceCollection.Find(s => s.Id == id).FirstOrDefaultAsync();
        return _mapper.Map<UpdateServiceDto>(service);  
    }

    public async Task UpdateAsync(UpdateServiceDto serviceDto)
    {
        var service = _mapper.Map<Service>(serviceDto);
        await _serviceCollection.FindOneAndReplaceAsync(s=>s.Id==service.Id, service);
    }
}
