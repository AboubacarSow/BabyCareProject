using BabyCareProject.Dtos.ContactDtos;
using BabyCareProject.Dtos.GalleryDtos;

namespace BabyCareProject.Models;

public class FooterModelView
{
    public List<ResultGalleryDto> Galleries {  get; set; }  
    public ResultContactDto Contact { get; set; }
}
