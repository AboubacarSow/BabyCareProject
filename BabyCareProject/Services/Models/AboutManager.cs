using AutoMapper;
using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models;

public class AboutManager : IAboutService
{
    private readonly IMongoCollection<About> _aboutCollection;
    private readonly IMapper _mapper;
    public AboutManager(IDataBaseSettings dataBaseSettings, IMapper mapper)
    {
        var client=new MongoClient(dataBaseSettings.ConnectionStrings);
        var database= client.GetDatabase(dataBaseSettings.DataBaseName);
        _aboutCollection = database.GetCollection<About>(dataBaseSettings.AboutCollection);
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateAboutDto aboutDto)
    {
        var about=_mapper.Map<About>(aboutDto);
        await _aboutCollection.InsertOneAsync(about);
    }

    public async Task DeleteAsync(string id)
    {
        await _aboutCollection.DeleteOneAsync(id);
    }

    public async Task<List<ResultAboutDto>> GetAllAsync()
    {
        var abouts=await _aboutCollection.AsQueryable().ToListAsync();
        return  _mapper.Map<List<ResultAboutDto>>(abouts);
    }

    public async Task<UpdateAboutDto> GetByIdAsync(string id)
    {
        var about = await _aboutCollection.Find(id).FirstOrDefaultAsync();
        return _mapper.Map<UpdateAboutDto>(about);
    }

    public async Task UpdateAsync(UpdateAboutDto aboutDto)
    {
        var about = _mapper.Map<About>(aboutDto);
        await _aboutCollection.FindOneAndReplaceAsync(a=>a.Id==about.Id,about);
    }
}
