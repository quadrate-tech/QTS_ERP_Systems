using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTS_ERP_Systems.Model
{
    [BsonIgnoreExtraElements]
    class Cheque
    {
        public int ChequeNumber { get; set; }
        public string Payee { get; set; }
        public int Amount { get; set; }
        public DateTime DueDate { get; set; }
        public string PaidBy { get; set; }
        public string  BankName { get; set; }
    }
}
