using AutoMapper;
using BabyCareProject.Dtos.EventDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping
{
    public class EventMapper : Profile
    {
        public EventMapper()
        {
            CreateMap<Event, ResultEventDto>();
            CreateMap<Event, UpdateEventDto>().ReverseMap();
            CreateMap<CreateEventDto, Event>();
        }
    }


}
