using System.ComponentModel.DataAnnotations;

namespace BabyCareProject.Dtos.SubscriberDtos;

public class CreateSubscriberDto
{
    [Required(ErrorMessage ="Mail Alanı Boş Geçilemez")]
    public string Email { get; set; }
}
