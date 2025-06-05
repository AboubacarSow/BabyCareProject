using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.Repositories.Entities;

public class Contact
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id {  get; set; } 
    public string Address { get; set; }
    public string Email { get; set; }
    public string Tel { get; set; }
    public string LocationUrl{get;set;}
    public string MapUrl { get; set; }

}


