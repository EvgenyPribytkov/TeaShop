using MongoDB.Bson;
using MongoDB.Driver;
using TeaShop.Models;

namespace TeaShop.Services
{
    public class TeasRepository
    {
        private IMongoClient _client;
        private IMongoDatabase _database;
        private IMongoCollection<Tea> _teasCollection;

        public TeasRepository(string connectionString)
        {
            _client = new MongoClient(connectionString);
            _database = _client.GetDatabase("TeaDb");
            _teasCollection = _database.GetCollection<Tea>("teas");
        }

        public async Task InsertTea(Tea tea)
        {
            await _teasCollection.InsertOneAsync(tea);
        }

        public async Task<List<Tea>> GetAllTeas()
        {
            return await _teasCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task<List<Tea>> GetTeasByField(string fieldName, string fieldValue)
        {
            var filter = Builders<Tea>.Filter.Eq(fieldName, fieldValue);
            var result = await _teasCollection.Find(filter).ToListAsync();

            return result;
        }

        public async Task<List<Tea>> GetTeas(int startingFrom, int count)
        {
            var result = await _teasCollection.Find(new BsonDocument())
                                               .Skip(startingFrom)
                                               .Limit(count)
                                               .ToListAsync();

            return result;
        }
        public async Task<bool> UpdateTea(ObjectId id, string udateFieldName, string updateFieldValue)
        {
            var filter = Builders<Tea>.Filter.Eq("_id", id);
            var update = Builders<Tea>.Update.Set(udateFieldName, updateFieldValue);

            var result = await _teasCollection.UpdateOneAsync(filter, update);

            return result.ModifiedCount != 0;
        }
        public async Task<bool> DeleteTeaById(ObjectId id)
        {
            var filter = Builders<Tea>.Filter.Eq("_id", id);
            var result = await _teasCollection.DeleteOneAsync(filter);
            return result.DeletedCount != 0;
        }

        public async Task<long> DeleteAllTeas()
        {
            var filter = new BsonDocument();
            var result = await _teasCollection.DeleteManyAsync(filter);
            return result.DeletedCount;
        }
    }
}
