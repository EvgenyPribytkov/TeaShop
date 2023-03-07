using MongoDB.Bson;
using MongoDB.Driver;
using TeaShop.Models;

namespace TeaShop.Services
{
    public class TeaOrdersRepository
    {
        private readonly IMongoCollection<TeaOrder> _teaOrders;

        public TeaOrdersRepository(string connectionString)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("teashop");
            _teaOrders = database.GetCollection<TeaOrder>("TeaOrders");
        }

        public async Task InsertTeaOrder(TeaOrder teaOrder)
        {
            await _teaOrders.InsertOneAsync(teaOrder);
        }

        public async Task<List<TeaOrder>> GetAllTeaOrders()
        {
            return await _teaOrders.Find(new BsonDocument()).ToListAsync();
        }
    }

}

