using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel;

namespace QTS_ERP_Systems.Model
{
    [BsonIgnoreExtraElements]
    public class BaseEntity
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

    }
}
