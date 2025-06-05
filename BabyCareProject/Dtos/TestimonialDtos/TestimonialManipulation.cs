namespace BabyCareProject.Dtos.TestimonialDtos;

public class TestimonialManipulation
{
    public string FullName { get; set; }
    public string? ImageUrl { get; set; }
    public IFormFile? ImageFile { get; set; }
    public string Comment { get; set; }
    public string Title { get; set; }
    public string Rate { get; set; }
}
