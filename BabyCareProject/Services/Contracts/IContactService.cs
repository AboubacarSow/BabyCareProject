using BabyCareProject.Dtos.ContactDtos;

namespace BabyCareProject.Services.Contracts;

public interface IContactService 
{
    Task<List<ResultContactDto>> GetAllAsync();
    Task<UpdateContactDto> GetByIdAsync(string id);
    Task CreateAsync(CreateContactDto contactDto);
    Task UpdateAsync(UpdateContactDto contactDto);
    Task DeleteAsync(string id);
}

