using System.ComponentModel.DataAnnotations;

namespace BabyCareProject.Dtos.ServiceDtos;

public class UpdateServiceDto
{
    public string Id { get; set; }
    [Required(ErrorMessage = "Ikon Alanı Boş Geçilemez")]
    public string Icon { get; set; }
    [Required(ErrorMessage = "Hizmet Adı Boş Geçilemez")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Açıklama Alanı Boş Geçilemez")]
    public string Description { get; set; }
}
