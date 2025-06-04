using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Dtos.TestimonialDtos;

namespace BabyCareProject.Services.Contracts
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllAsync();
        Task CreateAsync(CreateTestimonialDto testimonialDto);
        Task DeleteAsync(string id);
    }
}
