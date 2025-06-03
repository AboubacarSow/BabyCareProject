namespace BabyCareProject.Dtos.InstructorDtos
{
    public class UpdateInstructorDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImageUrl { get; set; }
        public IFormFile ImageFile { get; set; }

        public string Title { get; set; }
    }
}
