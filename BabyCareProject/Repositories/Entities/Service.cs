using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.Repositories.Entities;

public class Service
{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string Id { get; set; }  
    public string Icon { get; set; }
    public string Name { get; set; }    
    public string Description { get; set; } 
    
}
