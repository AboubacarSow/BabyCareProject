using BabyCareProject.Dtos.TestimonialDtos;
using BabyCareProject.Services.Contracts;

namespace BabyCareProject.Services.Models
{
    public class TestimonialManager : ITestimonialService
    {
        public Task CreateAsync(CreateTestimonialDto testimonialDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
