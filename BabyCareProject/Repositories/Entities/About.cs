using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.Repositories.Entities;
public class About
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string Slogan { get; set; }
    public string Description { get; set; } 
    public string VideoUrl { get; set; }    
    public List<string> Features { get; set; }
    

}
