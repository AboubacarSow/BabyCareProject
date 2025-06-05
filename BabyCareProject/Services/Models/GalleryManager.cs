using AutoMapper;
using BabyCareProject.Dtos.GalleryDtos;
using BabyCareProject.Infrastructure.Utilities;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models;
public class GalleryManager : IGalleryService
{
    private readonly IMongoCollection<Gallery> _galleryCollection;
    private readonly IMapper _mapper;
    public GalleryManager(IMapper mapper, IDataBaseSettings dataBaseSettings)
    {
        var client = new MongoClient(dataBaseSettings.ConnectionStrings);
        var database = client.GetDatabase(dataBaseSettings.DataBaseName);
        _galleryCollection = database.GetCollection<Gallery>(dataBaseSettings.GalleryCollection);
        _mapper = mapper;
    }
    public async Task CreateAsync(CreateGalleryDto galleryDto)
    {
        galleryDto.ImageUrl = await Media.UploadAsync(galleryDto.ImageFile);
        var _gallery = _mapper.Map<Gallery>(galleryDto);
        await _galleryCollection.InsertOneAsync(_gallery);
    }

    public async Task DeleteAsync(string id)
    {
        await _galleryCollection.DeleteOneAsync(c => c.Id == id);
    }

    public async Task<List<ResultGalleryDto>> GetAllAsync()
    {
        var galleries = await _galleryCollection.AsQueryable().ToListAsync();
        return _mapper.Map<List<ResultGalleryDto>>(galleries);
    }

    public async Task<UpdateGalleryDto> GetByIdAsync(string id)
    {
        var _event = await _galleryCollection.Find(c => c.Id == id).FirstOrDefaultAsync();
        return _mapper.Map<UpdateGalleryDto>(_event);
    }

    public async Task UpdateAsync(UpdateGalleryDto galleryDto)
    {
        if(galleryDto.ImageFile!=null)
            galleryDto.ImageUrl = await Media.UploadAsync(galleryDto.ImageFile);
        var gallery = _mapper.Map<Gallery>(galleryDto);
        await _galleryCollection.FindOneAndReplaceAsync(c => c.Id == gallery.Id, gallery);

    }
   
    
}
