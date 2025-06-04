using AutoMapper;
using BabyCareProject.Dtos.ServiceDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping
{
    public class ServiceMapper : Profile 
    {
        public ServiceMapper()
        {
            CreateMap<Service, ResultServiceDto>();
            CreateMap<Service, UpdateServiceDto>().ReverseMap();
            CreateMap<CreateServiceDto, Service>();
        }
    }


}
