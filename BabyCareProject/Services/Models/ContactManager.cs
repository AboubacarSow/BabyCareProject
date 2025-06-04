using BabyCareProject.Dtos.ContactDtos;
using BabyCareProject.Services.Contracts;

namespace BabyCareProject.Services.Models
{
    public class ContactManager : IContactService
    {
        public Task CreateAsync(CreateContactDto contactDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultContactDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateContactDto> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateContactDto contactDto)
        {
            throw new NotImplementedException();
        }
    }
}
