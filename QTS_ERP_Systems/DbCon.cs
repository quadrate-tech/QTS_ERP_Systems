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
        public void InsertEmployee<T>(string table, T record)
        {
            var Collection = db.GetCollection<T>(table);
            Collection.InsertOne(record);
        }
        public void InsertCustomer<T>(string table, T record)
        {
            var Collection = db.GetCollection<T>(table);
            Collection.InsertOne(record);
        }
        public void InsertBusinessModel<T>(string table, T record)
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
        public void UpdateCustomers(string table, string Customer_Id, string Customer_Name, string Address, string Email, int Contact_No)
        {
            var Collection = db.GetCollection<Employee>(table);
            var filter = Builders<Employee>.Filter.Eq("CustomerId", Customer_Id);
            var update = Builders<Employee>.Update.Set("CustomerName", Customer_Name)
                                                  .Set("Address", Address)
                                                  .Set("Email", Email)
                                                  .Set("ContactNo", Contact_No);
            Collection.UpdateOne(filter, update);
        }
        public void UpdateBusinessModel(string table, int Id, string Name, string Address, string Contact, bool IsActive)
        {
            var Collection = db.GetCollection<BusinessModel>(table);
            var filter = Builders<BusinessModel>.Filter.Eq("Id", Id);
            var update = Builders<BusinessModel>.Update.Set("Name", Name)
                                                  .Set("Address", Address)
                                                  .Set("Contact", Contact)
                                                  .Set("IsActive", IsActive);
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
        public List<Customer> FilterCustomer(string Customer_Name)
        {
            try
            {
                if (!string.IsNullOrEmpty(Customer_Name))
                {
                    IMongoCollection<Customer> Collection = db.GetCollection<Customer>("Customers");
                    var result = Collection.AsQueryable().Where(u => u.CustomerName.Contains(Customer_Name)).ToList();
                    return result;
                }
                else
                {
                    IMongoCollection<Customer> Collection = db.GetCollection<Customer>("Customers");
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
        public List<BusinessModel> FilterBusinessModel(string Name)
        {
            try
            {
                if (!string.IsNullOrEmpty(Name))
                {
                    IMongoCollection<BusinessModel> Collection = db.GetCollection<BusinessModel>("BusinessModels");
                    var result = Collection.AsQueryable().Where(u => u.Name.Contains(Name)).ToList();
                    return result;
                }

                else
                {
                    IMongoCollection<BusinessModel> Collection = db.GetCollection<BusinessModel>("BusinessModels");
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

        //public List<BusinessModel> BData(int Id) {
        //    IMongoCollection<BusinessModel> Collection = db.GetCollection<BusinessModel>("BusinessModels");
        //    var result = Collection.AsQueryable().Where(u => u.Id.Contains(Id)).ToList();
        //    return result;
        //}

        //public void isactivebtn(int id) {
        //    IMongoCollection<BusinessModel> Collection = db.GetCollection<BusinessModel>("BusinessModels");
        //    var item = Collection.AsQueryable().Where(u => u.Id== id);
        //    var data = Collection.AsQueryable().Where(u => u.Id != id).ToList();
        //    foreach (var d in data)
        //    {
        //      bool IsActiveLocal = false;
               
        //        var filterLocal = Builders<BusinessModel>.Filter.Eq("id", d);
        //        var updateLocal = Builders<BusinessModel>.Update.Set("IsActive", IsActiveLocal);

        //        Collection.UpdateOne(filterLocal, updateLocal);
        //    }
        //      bool IsActive = true;
        //    var filter = Builders<BusinessModel>.Filter.Eq("id", item);
        //    var update = Builders<BusinessModel>.Update.Set("IsActive", IsActive);
        //    Collection.UpdateOne(filter, update);
        //}
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
        public void DeleteEmployee(string Id)
        {
            IMongoCollection<Employee> collection = db.GetCollection<Employee>("Employees");
            collection.DeleteOne(a => a.Employee_Id == Id);
        }
        public void DeleteCustomer(string Id)
        {
            IMongoCollection<Customer> collection = db.GetCollection<Customer>("Customers");
            collection.DeleteOne(a => a.CustomerId== Id);
        }
        public void DeleteBusinessModel(int Id)
        {
            IMongoCollection<BusinessModel> collection = db.GetCollection<BusinessModel>("BusinessModels");
            collection.DeleteOne(a => a.Id == Id);
        }
    }
}
