

namespace BabyCareProject.Repositories.Settings
{
    public interface IDataBaseSettings
    {
        public string ConnectionStrings { get;set; }
        public string DataBaseName { get; set; }
        public string InstructorCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string AboutCollection { get; set; }
        public string ContactCollection { get; set; }
        public string EventCollection { get; set; }
        public string GalleryCollection { get; set; }
        public string MessageCollection { get; set; }
        public string ServiceCollection { get; set; }
        public string SocialMediaCollection { get; set; }
        public string SubscriberCollection { get; set; }
        public string TestimonialCollection {  get; set; }  
    }
}
