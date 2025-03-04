using AutoMapper;
using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models
{
    public class InstructorManager : IInstructorService
    {
        private readonly IMongoCollection<Instructor> _instructorCollection;
        private readonly IMapper _mapper;

        public InstructorManager(IMapper mapper,IDataBaseSettings dataBaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient(dataBaseSettings.ConnectionStrings);
            var database = client.GetDatabase(dataBaseSettings.DataBaseName);
            _instructorCollection = database.GetCollection<Instructor>(dataBaseSettings.InstructorCollectionName);
        }

        public async Task CreateAsync(CreateInstructorDto instructorDto)
        {
            var instructor = _mapper.Map<Instructor>(instructorDto);
            await _instructorCollection.InsertOneAsync(instructor);
        }

        public async Task DeleteAsync(string id)
        {
            await _instructorCollection.DeleteOneAsync(i => i.Id == id);
        }

        public async Task<List<ResultInstructorDto>> GetAllAsync()
        {
            var instructors = await _instructorCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultInstructorDto>>(instructors);
        }

        public async Task<UpdateInstructorDto> GetByIdAsync(string id)
        {
            var instructor = await _instructorCollection.Find(i => i.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateInstructorDto>(instructor);
        }

        public async Task UpdateAsync(UpdateInstructorDto instructorDto)
        {
            var instructor = _mapper.Map<Instructor>(instructorDto);
            await _instructorCollection.FindOneAndReplaceAsync(i => i.Id.Equals(instructor.Id), instructor);are
        }
    }
}
