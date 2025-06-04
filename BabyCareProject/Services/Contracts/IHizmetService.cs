using BabyCareProject.Dtos.ServiceDtos;

namespace BabyCareProject.Services.Contracts;

public interface IHizmetService
{
    Task<List<ResultServiceDto>> GetAllAsync();
    Task<UpdateServiceDto> GetByIdAsync(string id);
    Task CreateAsync(CreateServiceDto servicDto);
    Task UpdateAsync(UpdateServiceDto serviceDto);
    Task DeleteAsync(string id);
}

