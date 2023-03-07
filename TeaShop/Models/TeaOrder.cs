using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TeaShop.Models;

public class TeaOrder
{
    public int Id { get; set; }
    public string TeaName { get; set; }
    public float BasePrice { get; set; }
}
