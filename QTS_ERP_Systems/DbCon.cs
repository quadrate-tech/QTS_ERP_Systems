using MongoDB.Bson;
using MongoDB.Driver;
using QTS_ERP_Systems.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QTS_ERP_Systems
{
    class DbCon
    {
        private IMongoDatabase db;
        readonly string DbName = "QTS_ERP";

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

        public void UpdateCategory(string table,string Id, string categoryName)
        {
            var collection = db.GetCollection<Category>(table);
            var filter = Builders<Category>.Filter.Eq("Category_Id", Id);
            var update = Builders<Category>.Update.Set("Category_Name", categoryName);
            collection.UpdateOne(filter, update);
        }


        public List<Category> FilterCategory(string CatName)
        {
            try
            {
                if (!string.IsNullOrEmpty(CatName))
                {
                    IMongoCollection<Category> collection = db.GetCollection<Category>("Category");
                    var filter = Builders<Category>.Filter.Regex("Category_Name", new BsonRegularExpression($".*{CatName}*."));
                    var result = collection.Find(filter).ToList();
                    return result;
                }
                else
                {
                    IMongoCollection<Category> collection = db.GetCollection<Category>("Category");
                    List<Category> categoryList = collection.AsQueryable().ToList();
                    return categoryList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }    
        }
    }
}
