using BabyCareProject.Dtos.TestimonialDtos;

namespace BabyCareProject.Services.Contracts
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllAsync();
        Task<UpdateTestimonialDto> GetByIdAsync(string id);
        Task UpdateAsync(UpdateTestimonialDto socialMediaDto);
        Task CreateAsync(CreateTestimonialDto testimonialDto);
        Task DeleteAsync(string id);
    }
}
