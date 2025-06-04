using BabyCareProject.Dtos.SocialMediaDtos;
using BabyCareProject.Services.Contracts;

namespace BabyCareProject.Services.Models;

public class SocialMediaManager : ISocialMediaService
{
    public Task CreateAsync(CreateSocialMediaDto socialMediaDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ResultSocialMediaDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UpdateSocialMediaDto> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UpdateSocialMediaDto socialMediaDto)
    {
        throw new NotImplementedException();
    }
}
