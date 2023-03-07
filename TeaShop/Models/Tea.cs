using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TeaShop.Models;

public class Tea
{
    [BsonId]
    public ObjectId Id { get; set; }
    [BsonElement("imagetitle")]
    public string ImageTitle { get; set; }
    [BsonElement("teaname")]
    public string TeaName { get; set; }
    [BsonElement("size")]
    public string Size { get; set; }
    [BsonElement("baseprice")]
    public float BasePrice { get; set; } = 30;
    [BsonElement("chamomile")]
    public bool Chamomile { get; set; }
    [BsonElement("lavender")]
    public bool Lavender { get; set; }
    [BsonElement("mint")]
    public bool Mint { get; set; }
    [BsonElement("cardamom")]
    public bool Cardamom { get; set; }
    [BsonElement("cinnamon")]
    public bool Cinnamon { get; set; }
    [BsonElement("ginger")]
    public bool Ginger { get; set; }
    [BsonElement("finalprice")]
    public float FinalPrice { get; set; }

}
