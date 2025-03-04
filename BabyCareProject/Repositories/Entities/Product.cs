using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.Repositories.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Price { get; set; }
        public string InstructorName { get; set; }
    }
}
