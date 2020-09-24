using MongoDB.Bson.Serialization.Attributes;
using System;

namespace QTS_ERP_Systems.Model
{
    [BsonIgnoreExtraElements]
    class Category
    {
        public Guid Category_Id { get; set; }
        public string Category_Name { get; set; }
    }
}
