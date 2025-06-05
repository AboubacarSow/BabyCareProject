using AutoMapper;
using BabyCareProject.Dtos.MessageDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping
{
    public class MessageMapper:Profile
    {
        public MessageMapper()
        {
            CreateMap<Message, ResultMessageDto>();
            CreateMap<CreateMessageDto, Message>();
        }
    }


}
