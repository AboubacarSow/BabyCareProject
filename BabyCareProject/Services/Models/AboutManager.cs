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
    private readonly string BaseUrl = "https://www.youtube.com/embed/";
    public AboutManager(IDataBaseSettings dataBaseSettings, IMapper mapper)
    {
        var client=new MongoClient(dataBaseSettings.ConnectionStrings);
        var database= client.GetDatabase(dataBaseSettings.DataBaseName);
        _aboutCollection = database.GetCollection<About>(dataBaseSettings.AboutCollection);
        _mapper = mapper;
    }

    public async Task CreateAsync(CreateAboutDto aboutDto)
    {
        aboutDto.VideoUrl = BaseUrl + aboutDto.VideoID;
        var features= aboutDto.FeatureContent.Trim().Split(",");
        aboutDto.Features = [.. features.Select(f => f.Trim())];
        var about=_mapper.Map<About>(aboutDto);
        await _aboutCollection.InsertOneAsync(about);
    }

    public async Task DeleteAsync(string id)
    {
        await _aboutCollection.DeleteOneAsync(a=>a.Id==id);
    }

    public async Task<List<ResultAboutDto>> GetAllAsync()
    {
        var abouts=await _aboutCollection.AsQueryable().ToListAsync();
        return  _mapper.Map<List<ResultAboutDto>>(abouts);
    }

    public async Task<UpdateAboutDto> GetByIdAsync(string id)
    {
        var about = await _aboutCollection.Find(a=>a.Id==id).FirstOrDefaultAsync();
        var aboutDto=_mapper.Map<UpdateAboutDto>(about);
        aboutDto.FeatureContent = string.Join(", ",aboutDto?.Features?.Select(a=>a)?? []);
        return aboutDto;
    }

    public async Task UpdateAsync(UpdateAboutDto aboutDto)
    {
        if(aboutDto.VideoID!=string.Empty)
            aboutDto.VideoUrl = BaseUrl + aboutDto.VideoID;
        var features = aboutDto.FeatureContent.Trim().Split(",");
        aboutDto.Features = [.. features.Select(f => f.Trim())];
        var about = _mapper.Map<About>(aboutDto);
        await _aboutCollection.FindOneAndReplaceAsync(a=>a.Id==about.Id,about);
    }
}
