using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
namespace QTS_ERP_Systems.Model
{[BsonIgnoreExtraElements]
    class BusinessModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Contact { get; set; }
        [DefaultValue(false)]
        public bool IsActive { get; set; }
    }
}
