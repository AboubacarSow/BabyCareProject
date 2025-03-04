using AutoMapper;
using BabyCareProject.Dtos.InstructorDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping
{
    public class InstructorMapping :Profile
    {
        public InstructorMapping()
        {
            CreateMap<Instructor, ResultInstructorDto>();
            CreateMap<Instructor, UpdateInstructorDto>().ReverseMap();
            CreateMap<CreateInstructorDto, Instructor>();
        }
    }
}
