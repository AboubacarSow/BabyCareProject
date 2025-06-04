using AutoMapper;
using BabyCareProject.Dtos.ContactDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping
{
    public class ContactMapper : Profile
    {
        public ContactMapper()
        {
            CreateMap<Contact, ResultContactDto>();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<CreateContactDto, Contact>();
        }
    }


}
