using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BabyCareProject.Repositories.Entities;

public class Testimonial
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }
    public string FullName {  get; set; }   
    public string ImageUrl {  get; set; }   
    public string Comment {  get; set; }    
    public string Title { get; set; }
    public string Rate {  get; set; }   
}
