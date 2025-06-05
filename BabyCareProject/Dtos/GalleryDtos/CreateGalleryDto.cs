using System.ComponentModel.DataAnnotations;

namespace BabyCareProject.Dtos.GalleryDtos;
public class CreateGalleryDto
{
    public string? ImageUrl { get; set; }
    [Required(ErrorMessage ="Resim Alanı Boş Geçilemez")]
    public IFormFile ImageFile { get; set; }
}
