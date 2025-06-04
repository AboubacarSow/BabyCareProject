namespace BabyCareProject.Dtos.AboutDtos
{
    public class CreateAboutDto
    {
        public string Slogan { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }
        public List<string> Features { get; set; }
    }
}
