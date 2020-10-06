using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_ERP_Systems.Model
{
    [BsonIgnoreExtraElements]
    class Employee
    {
        public string Employee_Id { get; set; }
        public string Employee_Name { get; set; }
        public string Contact_No { get; set; }
        public string Address { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string SecretCode { get; set; }
    }
}
