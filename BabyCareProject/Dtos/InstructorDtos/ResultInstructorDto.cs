namespace BabyCareProject.Dtos.InstructorDtos
{
    public class ResultInstructorDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Concat(FirstName, " ", LastName);
        public string ImageUrl { get; set; }
        public string Title { get; set; }
    }
}
