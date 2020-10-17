using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_ERP_Systems.Model
{
    [BsonIgnoreExtraElements]
    class Vehicle
    {
        [Key]
        public string vehicle_no { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public string type { get; set; }
        public int current_mileage { get; set; }
        public int service_mileage_due { get; set; }
        public string owner { get; set; }
        public DateTime added_date { get; set; }

    }
}
