using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace FishingHelper.Models
{
    public class Fish
    {
        [BsonId]
        [BsonRepresentation((BsonType.ObjectId))]
        public string Id { get; set; }

        [BsonElement("FishType")]
        [JsonProperty("FishType")]
        public string FishType { get; set; }

        [BsonElement("Season")] 
        [JsonProperty("Season")]
        public string Season { get; set; }

        [BsonElement("Weather")] 
        [JsonProperty("Weather")]
        public string Weather { get; set; }

        [BsonElement("Weight")] 
        [JsonProperty("Weight")]
        public int Weight { get; set; }
    }
}


