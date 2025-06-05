using AutoMapper;
using BabyCareProject.Dtos.SocialMediaDtos;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models;

public class SocialMediaManager : ISocialMediaService
{
    private readonly IMongoCollection<SocialMedia> _socialMediaCollection;
    private readonly IMapper _mapper;

    public SocialMediaManager(IMapper mapper, IDataBaseSettings dataBaseSettings)
    {
        _mapper = mapper;
        var client=new MongoClient(dataBaseSettings.ConnectionStrings);
        var database = client.GetDatabase(dataBaseSettings.DataBaseName);
        _socialMediaCollection=database.GetCollection<SocialMedia>(dataBaseSettings.SocialMediaCollection);
    }
    public async Task CreateAsync(CreateSocialMediaDto socialMediaDto)
    {
        var socialMedia= _mapper.Map<SocialMedia>(socialMediaDto);
        await _socialMediaCollection.InsertOneAsync(socialMedia);   
    }

    public async Task DeleteAsync(string id)
    {
        await _socialMediaCollection.DeleteOneAsync(s => s.Id == id);
    }

    public async Task<List<ResultSocialMediaDto>> GetAllAsync()
    {
        var socials = await _socialMediaCollection.AsQueryable().ToListAsync();
        return _mapper.Map<List<ResultSocialMediaDto>>(socials);
    }

    public async Task<UpdateSocialMediaDto> GetByIdAsync(string id)
    {
        var social=await _socialMediaCollection.Find(s=>s.Id==id).FirstOrDefaultAsync();
        return _mapper.Map<UpdateSocialMediaDto>(social);
    }

    public async Task UpdateAsync(UpdateSocialMediaDto socialMediaDto)
    {
        var social= _mapper.Map<SocialMedia>(socialMediaDto);
        await _socialMediaCollection.FindOneAndReplaceAsync(s => s.Id == social.Id, social);

    }
}
