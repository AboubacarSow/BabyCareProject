using AutoMapper;
using BabyCareProject.Dtos.TestimonialDtos;
using BabyCareProject.Infrastructure.Utilities;
using BabyCareProject.Repositories.Entities;
using BabyCareProject.Repositories.Settings;
using BabyCareProject.Services.Contracts;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.Models
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly IMongoCollection<Testimonial> _testimonialCollection;
        private readonly IMapper _mapper;
        public TestimonialManager(IDataBaseSettings dataBaseSettings, IMapper mapper)
        {
            var client =new MongoClient(dataBaseSettings.ConnectionStrings);
            var database=client.GetDatabase(dataBaseSettings.DataBaseName);
            _testimonialCollection = database.GetCollection<Testimonial>(dataBaseSettings.TestimonialCollection);
            _mapper = mapper;
        }
        public async Task CreateAsync(CreateTestimonialDto testimonialDto)
        {
            testimonialDto.ImageUrl = await Media.UploadAsync(testimonialDto.ImageFile);
            var testimonial= _mapper.Map<Testimonial>(testimonialDto);  
            await _testimonialCollection.InsertOneAsync(testimonial);   
        }
        public async Task DeleteAsync(string id)
        {
            await _testimonialCollection.DeleteOneAsync(t=>t.Id==id);    
        }
        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {

            var testimonials = await _testimonialCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultTestimonialDto>>(testimonials);   
        }
        public async Task<UpdateTestimonialDto> GetByIdAsync(string id)
        {
            var social = await _testimonialCollection.Find(s => s.Id == id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateTestimonialDto>(social);
        }

        public async Task UpdateAsync(UpdateTestimonialDto testimonialDto)
        {
            if (testimonialDto.ImageFile != null)
                testimonialDto.ImageUrl = await Media.UploadAsync(testimonialDto.ImageFile);
            var social = _mapper.Map<Testimonial>(testimonialDto);
            await _testimonialCollection.FindOneAndReplaceAsync(s => s.Id == social.Id, social);

        }
    }
}
