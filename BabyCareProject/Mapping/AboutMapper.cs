using AutoMapper;
using BabyCareProject.Dtos.AboutDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping;
public class AboutMapper:Profile
{
    public AboutMapper()
    {
        CreateMap<About, ResultAboutDto>();
        CreateMap<About, UpdateAboutDto>().ReverseMap();
        CreateMap<CreateAboutDto, About>();
    }
}
