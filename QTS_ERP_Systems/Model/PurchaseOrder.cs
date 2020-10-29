using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel;

namespace QTS_ERP_Systems.Model
{
    [BsonIgnoreExtraElements]
    public class PurchaseOrder:BaseEntity
    {
        public string Date { get; set; }
        [DefaultValue(false)]
        public bool IsReceived { get; set; }
    }
}
