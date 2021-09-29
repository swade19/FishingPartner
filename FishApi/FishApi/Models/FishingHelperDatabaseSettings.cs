using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingHelper.Models
{
    public class FishingHelperDatabaseSettings : IFishingHelperDatabaseSettings
    {
        public string FishCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IFishingHelperDatabaseSettings 
    { 
        public string FishCollectionName { get; set; } 
        public string ConnectionString { get; set; } 
        public string DatabaseName { get; set; }
    }
}
