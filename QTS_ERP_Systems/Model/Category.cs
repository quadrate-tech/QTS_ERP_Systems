﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel;
using System.Security.Permissions;

namespace QTS_ERP_Systems.Model
{
    [BsonIgnoreExtraElements]
    class Category
    {
        public string Category_Id { get; set; }
        public string Category_Name { get; set; }
    }
}
