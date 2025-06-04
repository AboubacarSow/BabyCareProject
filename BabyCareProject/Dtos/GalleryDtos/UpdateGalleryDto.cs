namespace BabyCareProject.Dtos.GalleryDtos
{
    public class UpdateGalleryDto
    {
        public string Id { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
