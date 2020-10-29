using MongoDB.Bson.Serialization.Attributes;

namespace QTS_ERP_Systems.Model
{
    [BsonIgnoreExtraElements]
    public class OrderedItem:BaseEntity
    {
        public string ItemCode { get; set; }
        public string OrderedDate { get; set; }
        public int Quantity { get; set; }
        public string UnitType { get; set; }
        public bool IsReceived { get; set; }
    }
}
