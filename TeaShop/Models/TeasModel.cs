using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace TeaShop.Models;

public class TeasModel
{
    public int Id { get; set; }
    public string ImageTitle { get; set; }
    public string TeaName { get; set; }
    public string Size { get; set; }
    public float BasePrice { get; set; } = 30;
    public bool Chamomile { get; set; }
    public bool Lavender { get; set; }
    public bool Mint { get; set; }
    public bool Cardamom { get; set; }
    public bool Cinnamon { get; set; }
    public bool Ginger { get; set; }
    public float FinalPrice { get; set; }

}
