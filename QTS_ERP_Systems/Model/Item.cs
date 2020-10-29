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
    public class Item :BaseEntity
    {
        [Key]
        public int item_id { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string printable_name { get; set; }
        public string unit_type { get; set; }
        public int unit_cost { get; set; }
        public string barcode { get; set; }
        public int stock_quantity { get; set; }
        public int selling_price { get; set; }
        public bool is_service { get; set; }

    }
}
