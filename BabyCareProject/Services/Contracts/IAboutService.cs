using BabyCareProject.Dtos.AboutDtos;

namespace BabyCareProject.Services.Contracts;

public interface IAboutService
{
    Task<List<ResultAboutDto>> GetAllAsync();
    Task<UpdateAboutDto> GetByIdAsync(string id);
    Task CreateAsync(CreateAboutDto aboutDto);
    Task UpdateAsync(UpdateAboutDto aboutDto);
    Task DeleteAsync(string id);
}
