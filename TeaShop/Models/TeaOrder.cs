using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TeaShop.Models;

public class TeaOrder
{
    [BsonId]
    public ObjectId Id { get; set; }
    [BsonElement("teaname")]
    public string TeaName { get; set; }
    [BsonElement("baseprice")]
    public float BasePrice { get; set; }
}
