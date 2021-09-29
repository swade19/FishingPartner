using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishingHelper.Models;
using MongoDB.Driver;

namespace FishingHelper.Services
{
    public class FishService
    {
        private readonly IMongoCollection<Fish> _fish;

        public FishService(IFishingHelperDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _fish = database.GetCollection<Fish>(settings.FishCollectionName);
        }

        public List<Fish> Get() =>
            _fish.Find(fish => true).ToList();

        public Fish Get(string id) =>
            _fish.Find<Fish>(fish => fish.Id == id).FirstOrDefault();

        public Fish Create(Fish fish)
        {
            _fish.InsertOne(fish);
            return fish;
        }

        public void Update(string id, Fish fishIn) =>
            _fish.ReplaceOne(fish => fish.Id ==id, fishIn);

        public void Remove(string id) =>
            _fish.DeleteOne(fish => fish.Id == id);
    }
}
