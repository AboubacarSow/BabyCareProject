using BabyCareProject.Dtos.GalleryDtos;
using BabyCareProject.Services.Contracts;

namespace BabyCareProject.Services.Models
{
    public class GalleryManager : IGalleryService
    {
        public Task CreateAsync(CreateGalleryDto galleryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultGalleryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UpdateGalleryDto> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(UpdateGalleryDto galleryDto)
        {
            throw new NotImplementedException();
        }
    }
}
