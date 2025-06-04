using AutoMapper;
using BabyCareProject.Dtos.GalleryDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping
{
    public class GalleryMapper : Profile 
    { 
        public GalleryMapper()
        {
            CreateMap<Gallery, ResultGalleryDto>();
            CreateMap<Gallery, UpdateGalleryDto>().ReverseMap();
            CreateMap<CreateGalleryDto, Gallery>();
        }
    }


}
