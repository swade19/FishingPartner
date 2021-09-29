using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FishingHelper.Models
{
    public class Fish
    {
        [BsonId]
        [BsonRepresentation((BsonType.ObjectId))]
        public string Id { get; set; }

        [BsonElement("FishType")] public string FishType { get; set; }

        [BsonElement("Season")] public string Season { get; set; }

        [BsonElement("Weather")] public string Weather { get; set; }

        [BsonElement("Weight")] public int Weight { get; set; }
    }
}


