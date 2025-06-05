using AutoMapper;
using BabyCareProject.Dtos.SubscriberDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping;

public class SubscriberMapper:Profile
{
    public SubscriberMapper()
    {
        CreateMap<Subscriber,ResultSubscriberDto>();
        CreateMap<CreateSubscriberDto, Subscriber>();
    }
}
