using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.Repositories.Entities;

public class Event
{

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string ImageUrl { get; set; } 
    public string Location { get; set; }
    public string Date { get; set; }
    public string StartAt { get; set; }
    public string EndAt { get; set; } = string.Empty;
    public string Name { get; set; }
    public string Description { get; set; } = string.Empty;
}
