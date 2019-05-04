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
        private IMongoCollection<PlantProfile> PlantsCollection { get; }
        
        public MongoDBMain(string databaseName, string collectionName, string databaseUrl)
        {
            var mongoClient = new MongoClient(databaseUrl);

            var mongoDatabase = mongoClient.GetDatabase(databaseName);
            PlantsCollection = mongoDatabase.GetCollection<PlantProfile>(collectionName);
        }

        public async Task InsertPlantsProfile(PlantProfile pl) => await PlantsCollection.InsertOneAsync(pl);

        public async Task <List<PlantProfile>> GetAllPlantsProfiles()
        {
            var plants = new List<PlantProfile>();

            var allPlants = await PlantsCollection.FindAsync(new BsonDocument());
            await allPlants.ForEachAsync(plant => plants.Add(plant));
            return plants;
        }
    }
}
