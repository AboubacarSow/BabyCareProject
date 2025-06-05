namespace BabyCareProject.Dtos.AboutDtos
{
    public class UpdateAboutDto
    {
        public string Id { get; set; }
        public string Slogan { get; set; }
        public string Description { get; set; }
        public string VideoID { get; set; }
        public string? VideoUrl { get; set; }
        public string FeatureContent { get; set; }
        public List<string>? Features { get; set; }
    }
}
