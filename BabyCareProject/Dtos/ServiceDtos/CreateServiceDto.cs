using System.ComponentModel.DataAnnotations;

namespace BabyCareProject.Dtos.ServiceDtos;

public class CreateServiceDto
{
    [Required(ErrorMessage ="Ikon Alanı Boş Geçilemez")]
    public required string Icon { get; set; }
    [Required(ErrorMessage = "Hizmet Adı Alanı Boş Geçilemez")]
    public required string Name { get; set; }
    [Required(ErrorMessage = "Açıklama Alanı Boş Geçilemez")]
    public required string Description { get; set; }
}
