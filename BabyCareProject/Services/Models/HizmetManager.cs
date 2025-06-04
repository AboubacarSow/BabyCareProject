using BabyCareProject.Dtos.ServiceDtos;
using BabyCareProject.Services.Contracts;

namespace BabyCareProject.Services.Models;

public class HizmetManager : IHizmetService
{
    public Task CreateAsync(CreateServiceDto servicDto)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ResultServiceDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UpdateServiceDto> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UpdateServiceDto serviceDto)
    {
        throw new NotImplementedException();
    }
}
