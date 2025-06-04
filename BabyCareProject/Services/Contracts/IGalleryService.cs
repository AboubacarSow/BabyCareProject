using BabyCareProject.Dtos.GalleryDtos;

namespace BabyCareProject.Services.Contracts;

public interface IGalleryService
{
    Task<List<ResultGalleryDto>> GetAllAsync();
    Task<UpdateGalleryDto> GetByIdAsync(string id);
    Task CreateAsync(CreateGalleryDto galleryDto);
    Task UpdateAsync(UpdateGalleryDto galleryDto);
    Task DeleteAsync(string id);
}

