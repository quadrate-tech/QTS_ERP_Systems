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
        public void InsertEmployee<T>(string table, T record)
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
        public void UpdateEmployee(string table,string Employee_Id,string Employee_Name, int Contact_No, string Address, string Email, string SecretCode)
        {
            var Collection = db.GetCollection<Employee>(table);
            var filter = Builders<Employee>.Filter.Eq("Employee_Id", Employee_Id);
            var update = Builders<Employee>.Update.Set("Employee_Name", Employee_Name)
                                                  .Set("Contact_No", Contact_No)
                                                  .Set("Address", Address)
                                                  .Set("Email", Email)
                                                  .Set("SecretCode", SecretCode);
            Collection.UpdateOne(filter, update);
        }

        public List<Employee> FilterEmployee(string EmpName)
        {
            try
            {
                if (!string.IsNullOrEmpty(EmpName))
                {
                    IMongoCollection<Employee> collection = db.GetCollection<Employee>("Employees");
                    var result = collection.AsQueryable().Where(u => u.Employee_Name.ToLower().Contains(EmpName)).ToList();
                    return result;
                }
                else
                {
                    IMongoCollection<Employee> collection = db.GetCollection<Employee>("Employees");
                    var result = collection.AsQueryable().ToList();
                    return result;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                throw;
            }
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


        public void DeleteOne(string Id)
        {
            IMongoCollection<Category> collection = db.GetCollection<Category>("Category");
            collection.DeleteOne(a=>a.Category_Id == Id);
        }
        public void DeleteEmployee(string Id)
        {
            IMongoCollection<Employee> collection = db.GetCollection<Employee>("Employees");
            collection.DeleteOne(a => a.Employee_Id == Id);
        }
    }
}
