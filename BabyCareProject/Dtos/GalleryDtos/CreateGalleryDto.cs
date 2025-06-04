namespace BabyCareProject.Dtos.GalleryDtos;
public class CreateGalleryDto
{
    public string? ImageUrl { get; set; }
    public IFormFile ImageFile { get; set; }
}
