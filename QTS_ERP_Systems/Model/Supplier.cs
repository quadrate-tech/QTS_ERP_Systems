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
    class Supplier
    {
        public int SupplierId { get; set; }
        
  
        public string Name { get; set; }

        [Required]
        public string Contact { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public float PendingAmount { get; set; }
    }
}
