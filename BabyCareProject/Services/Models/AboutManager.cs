using AutoMapper;
using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using NuGet.Protocol;

namespace BabyCareProject.Services.Models
{
    public class AboutManager : IAboutService
    {
        private readonly IMongoCollection<About> _aboutCollection;
        private IMapper _mapper;
        public AboutManager(IDataBaseSettings dataBaseSettings, IMapper mapper)
        {
            var client=new MongoClient(dataBaseSettings.ConnectionStrings);
            var database= client.GetDatabase(dataBaseSettings.DataBaseName);
            _aboutCollection = database.GetCollection<About>(dataBaseSettings.AboutCollection);
            _mapper = mapper;
        }

        public Task CreateAsync(CreateAboutDto aboutDto)
        {
            
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultAboutDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateAboutDto> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateAboutDto aboutDto)
        {
            throw new NotImplementedException();
        }
    }
}
