using MongoDB.Driver;
using QTS_ERP_Systems.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QTS_ERP_Systems
{
    class DbCon
    {
        private readonly IMongoDatabase db;
        readonly string DbName = "QTS_ERP";

        //create connection
        public DbCon()
        {
            var client = new MongoClient();
            db = client.GetDatabase(DbName);
        }

        public void InsertCategory<T>(string table, T record)
        {
            var Collection = db.GetCollection<T>(table);
            Collection.InsertOne(record);
        }
        public void InsertCheque<T>(string table, T record)
        {
            var Collection = db.GetCollection<T>(table);
            Collection.InsertOne(record);
        }
        public void UpdateCategory(string table,string Id, string categoryName)
        {
            var collection = db.GetCollection<Category>(table);
            var filter = Builders<Category>.Filter.Eq("Category_Id", Id);
            var update = Builders<Category>.Update.Set("Category_Name", categoryName);
            collection.UpdateOne(filter, update);
        }
        public void UpdateCheque(string table, int ChqNo, string Payee, int Amount, DateTime DueDate, string PaidBy, string BankName)
        {
            var Collection = db.GetCollection<Cheque>(table);
            var filter = Builders<Cheque>.Filter.Eq("ChequeNumber", ChqNo);
            var update = Builders<Cheque>.Update.Set("Payee", Payee)
                                                .Set("Amount", Amount)
                                                .Set("DueDate", DueDate)
                                                .Set("PaidBy", PaidBy)
                                                .Set("BankName", BankName);
            Collection.UpdateOne(filter, update);
        }


        public List<Category> FilterCategory(string CatName)
        {
            try
            {
                if (!string.IsNullOrEmpty(CatName))
                {
                    IMongoCollection<Category> collection = db.GetCollection<Category>("Category");
                    var result = collection.AsQueryable().Where(c => c.Category_Name.ToLower().Contains(CatName)).ToList();
                    return result;
                }
                else
                {
                    IMongoCollection<Category> collection = db.GetCollection<Category>("Category");
                    var result = collection.AsQueryable().ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }    
        }
        public List<Cheque> FilterCheque(string ChequeNo)
        {
            try
            {
                if (!string.IsNullOrEmpty(ChequeNo))
                {
                    IMongoCollection<Cheque> Collection = db.GetCollection<Cheque>("Cheques");
                    var result = Collection.AsQueryable().Where(u => u.ChequeNumber == Convert.ToInt32(ChequeNo)).ToList();
                    return result;
                }
                else
                {
                    IMongoCollection<Cheque> Collection = db.GetCollection<Cheque>("Cheques");
                    var result = Collection.AsQueryable().ToList();
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void DeleteOne(string Id)
        {
            IMongoCollection<Category> collection = db.GetCollection<Category>("Category");
            collection.DeleteOne(a=>a.Category_Id == Id);
        }
        public void DeleteCheque(int ChqNo)
        {
            IMongoCollection<Cheque> Collection = db.GetCollection<Cheque>("Cheques");
            Collection.DeleteOne(a => a.ChequeNumber == ChqNo);
        }
        
        public bool CheckChequeNo(int ChqNo)
        {
            IMongoCollection<Cheque> Collection = db.GetCollection<Cheque>("Cheques");
            var Check = Collection.AsQueryable().Any(u => u.ChequeNumber == ChqNo);
            //bool C = Check;
            return Check;
        }
    }
}
