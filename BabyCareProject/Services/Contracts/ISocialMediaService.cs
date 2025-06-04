using BabyCareProject.Dtos.SocialMediaDtos;

namespace BabyCareProject.Services.Contracts;

public interface ISocialMediaService
{
    Task<List<ResultSocialMediaDto>> GetAllAsync();
    Task<UpdateSocialMediaDto> GetByIdAsync(string id);
    Task CreateAsync(CreateSocialMediaDto socialMediaDto);
    Task UpdateAsync(UpdateSocialMediaDto socialMediaDto);
    Task DeleteAsync(string id);
}

