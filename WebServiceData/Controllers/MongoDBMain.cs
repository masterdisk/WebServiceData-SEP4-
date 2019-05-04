using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebServiceData.Models;

namespace WebServiceData.Controllers
{
    public class MongoDBMain  
    {
        private IMongoCollection<PlantProfile> AccountcsCollection { get; }
        
        public MongoDBMain(string databaseName, string collectionName, string databaseUrl)
        {
            var mongoClient = new MongoClient(databaseUrl);

            var mongoDatabase = mongoClient.GetDatabase(databaseName);
            AccountcsCollection = mongoDatabase.GetCollection<PlantProfile>(collectionName);
        }

        public async Task InsertAccount(PlantProfile acc) => await AccountcsCollection.InsertOneAsync(acc);

        public async Task <List<PlantProfile>> GetAllAccountcs()
        {
            var account = new List<PlantProfile>();

            var allAccountcs = await AccountcsCollection.FindAsync(new BsonDocument());
            await allAccountcs.ForEachAsync(accounts => account.Add(accounts));
            return account;
        }
    }
}
