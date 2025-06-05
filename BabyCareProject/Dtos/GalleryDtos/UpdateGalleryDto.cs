using System.ComponentModel.DataAnnotations;

namespace BabyCareProject.Dtos.GalleryDtos
{
    public class UpdateGalleryDto
    {
        [Required(ErrorMessage = "ID Boş Olamaz")]
        public string Id { get; set; }
        [Required(ErrorMessage ="Resim Alanı Boş Geçilemez")]
        public string ImageUrl { get; set; }
        public IFormFile? ImageFile { get; set; }
    }
}
