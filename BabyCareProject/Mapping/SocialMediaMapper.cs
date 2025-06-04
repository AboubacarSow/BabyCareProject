using AutoMapper;
using BabyCareProject.Dtos.SocialMediaDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping
{
    public class SocialMediaMapper:Profile
    {
        public SocialMediaMapper()
        {
            CreateMap<SocialMedia, ResultSocialMediaDto>();
            CreateMap<SocialMedia, UpdateSocialMediaDto>().ReverseMap();
            CreateMap<CreateSocialMediaDto, SocialMedia>();
        }
    }


}
