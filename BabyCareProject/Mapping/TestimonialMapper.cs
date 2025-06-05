using AutoMapper;
using BabyCareProject.Dtos.TestimonialDtos;
using BabyCareProject.Repositories.Entities;

namespace BabyCareProject.Mapping
{
    public class TestimonialMapper : Profile
    {
        public TestimonialMapper()
        {
            CreateMap<Testimonial, ResultTestimonialDto>();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();

            CreateMap<CreateTestimonialDto, Testimonial>();
        }
    }


}
